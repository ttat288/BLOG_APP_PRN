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
        string Email, Pass;


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

    }
}
