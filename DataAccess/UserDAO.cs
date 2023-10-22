using DataAccess.DBContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        //---Login
        public bool Login(string mail, string pass)
        {
            using (var context = new MyDbContext())
            {
                var user = context.UserTb.FirstOrDefault(u => u.mail == mail);

                if (user != null)
                {
                    // Kiểm tra mật khẩu
                    if (user.password == pass)
                    {
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




        //test
        public string img()
        {
            string pathImg = "";
            using (var context = new MyDbContext())
            {
                var users = context.UserTb.ToList();

                var user = users.FirstOrDefault(u => u.id == "SE171871");

                if (user != null)
                {
                    string avatarPath = user.avatar;

                    if (!string.IsNullOrEmpty(avatarPath))
                    {
                        pathImg = avatarPath;
                    }
                    //else
                    //{

                    //}
                }
            }
            return pathImg;
        }


    }
}
