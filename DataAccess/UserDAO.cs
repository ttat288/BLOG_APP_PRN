using DataAccess.DBContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlogObject;
using Microsoft.VisualBasic;

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
            using (var context = new MyDbContext())
            {
                var user = context.UserTb.FirstOrDefault(u => u.mail == mail);

                if (user != null)
                {
                    // Kiểm tra mật khẩu
                    if (user.password == pass)
                    {
                        Account.Instance.id = user.id;
                        Account.Instance.avt = user.avatar;
                        Account.Instance.Remember = rem;
                        Account.Instance.Email = user.mail;
                        Account.Instance.Pass = user.password;
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
        public User user(string id)
        {
            using (var context = new MyDbContext())
            {
                // Tìm người dùng dựa vào ID
                var user = context.UserTb.FirstOrDefault(u => u.id == id);

                // Kiểm tra xem người dùng có tồn tại không
                if (user != null)
                {
                    // Trả về thông tin người dùng
                    return new User
                    {
                        id = user.id,
                        mail = user.mail,
                        avatar = user.avatar,
                        name = user.name
                    };
                }
                else
                {
                    // Trả về null nếu không tìm thấy người dùng
                    return null;
                }
            }
        }

        public bool CreateUser(User newUser)
        {
            try
            {
                using (var context = new MyDbContext())
                {
                    // Kiểm tra xem người dùng đã tồn tại chưa
                    var existingUser = context.UserTb.FirstOrDefault(u => u.mail == newUser.mail || u.id == newUser.id);

                    if (existingUser == null)
                    {
                        // Người dùng chưa tồn tại, thêm mới
                        context.UserTb.Add(newUser);
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
