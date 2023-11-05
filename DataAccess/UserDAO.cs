using System;
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
        public bool Login(string mail, string pass,bool rem)
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
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    // tài khoản không tồn tại
                    return false;
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


    }
}
