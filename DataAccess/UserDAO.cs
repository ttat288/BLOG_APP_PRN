using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using BlogObject;
using BlogObject.Models;

namespace DataAccess
{
    public class UserDAO
    {
        //-----instance
        private static UserDAO instance = null; private static readonly object instanceLock = new object();
        private UserDAO() { }
        public static UserDAO Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new UserDAO();
                    }
                    return instance;
                }
            }
        }
        //============================================
        string Email, Pass, avatarOfUser, userID;

        //---Login
        public string Login(string mail, string pass, bool rem)
        {
            using (var context = new BlogPrnContext())
            {
                var user = context.UserTbls.FirstOrDefault(u => u.Email == mail);

                if (user != null)
                {
                    // Kiểm tra mật khẩu
                    if (user.Password == pass)
                    {
                        Account.Instance.id = user.UserId;
                        Account.Instance.avt = user.Avatar;
                        Account.Instance.Remember = rem;
                        Account.Instance.Email = user.Email;
                        Account.Instance.Pass = user.Password;
                        Account.Instance.Role = user.Role;
                        // Đăng nhập thành công
                        return user.Role;
                    }
                    else
                    {
                        return "error";
                    }
                }
                else
                {
                    // tài khoản không tồn tại
                    return "error";
                }
            }
        }

        public Account remember()
        {
            return Account.Instance;
        }
        public UserTbl user(string id)
        {
            using (var context = new BlogPrnContext())
            {
                // Tìm người dùng dựa vào ID
                var user = context.UserTbls.FirstOrDefault(u => u.UserId == id);

                // Kiểm tra xem người dùng có tồn tại không
                if (user != null)
                {
                    // Trả về thông tin người dùng
                    return new UserTbl
                    {
                        UserId = user.UserId,
                        Email = user.Email,
                        Avatar = user.Avatar,
                        Name = user.Name
                    };
                }
                else
                {
                    // Trả về null nếu không tìm thấy người dùng
                    return null;
                }
            }
        }

        public bool CreateUser(UserTbl newUser)
        {
            try
            {
                using (var context = new BlogPrnContext())
                {
                    // Kiểm tra xem người dùng đã tồn tại chưa
                    var existingUser = context.UserTbls.FirstOrDefault(u => u.Email == newUser.Email || u.UserId == newUser.UserId);

                    if (existingUser == null)
                    {
                        // Người dùng chưa tồn tại, thêm mới
                        context.UserTbls.Add(newUser);
                        context.SaveChanges();
                        return true;
                    }
                    else
                    {
                        // Người dùng đã tồn tại
                        return false;
                    }
                }
            }
            catch (Exception ex)
            {
                // Xử lý ngoại lệ nếu có lỗi khi tạo tài khoản
                Console.WriteLine($"Lỗi khi tạo tài khoản: {ex.ToString()}");
                return false;
            }
        }
        public void DeleteUser(string userID)
        {
            using (var context = new BlogPrnContext())
            {
                // Kiểm tra xem người dùng có tồn tại không
                var userToDelete = context.UserTbls.SingleOrDefault(u => u.UserId == userID);

                if (userToDelete != null)
                {

                    LikeDAO.Instance.DeleteLikeByUserID(userID);
                    CommentDAO.Instance.DeleteCommentByUserID(userID);

                    // Delete all posts with this user
                    List<PostTbl> list = context.PostTbls.Where(p => p.PostId.StartsWith(userID)).ToList();
                    foreach (var post in list)
                    {
                        PostDAO.Instance.DeletePost(post.PostId);
                    }

                    // Delete this user
                    deleteUser2(userID);
                    context.SaveChanges();
                }
                else
                {
                    // Xử lý khi không tìm thấy người dùng
                    Debug.WriteLine("Người dùng không tồn tại");
                }
            }
        }
        public void deleteUser2(string userID)
        {
            using (var context = new BlogPrnContext())
            {
                var userToDelete = context.UserTbls.SingleOrDefault(u => u.UserId == userID);

                context.UserTbls.Remove(userToDelete);
                context.SaveChanges();
            }
        }

        public List<UserTbl> GetAllUser()
        {
            using (var context = new BlogPrnContext())
            {
                return context.UserTbls.Where(u => u.Role != "admin").ToList();
            }
        }
        public void UpdateUser(string userID, string role, string major)
        {
            using (var context = new BlogPrnContext())
            {
                // Tìm người dùng cần cập nhật
                var userToUpdate = context.UserTbls.SingleOrDefault(u => u.UserId == userID);

                if (userToUpdate != null)
                {
                    // Cập nhật thông tin người dùng
                    userToUpdate.Role = role;
                    userToUpdate.Major = major;

                    // Lưu thay đổi vào cơ sở dữ liệu
                    context.SaveChanges();
                }
                else
                {
                    // Xử lý khi không tìm thấy người dùng
                    throw new Exception("Người dùng không tồn tại");
                }
            }
        }
    }
}
