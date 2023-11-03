using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static DataAccess.UserDAO;
using BlogObject;
using System.Runtime.Intrinsics.Arm;

namespace DataAccess.Repository
{
    public class UserRepository : IUserRepository
    {
        public bool CreateUser(User newUser)
        {
            return UserDAO.Instance.CreateUser(newUser);
        }

        public bool Login(string mail, string pass, bool rem)
        {
            return UserDAO.Instance.Login(mail, pass, rem);
        }

        public Account remember()
        {
            return UserDAO.Instance.remember();
        }

        public User user(string id)
        {
            return UserDAO.Instance.user(id);
        }
    }
}
