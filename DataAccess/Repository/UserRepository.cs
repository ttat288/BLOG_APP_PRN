using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static DataAccess.UserDAO;
using BlogObject;

namespace DataAccess.Repository
{
    public class UserRepository : IUserRepository
    {
        public bool Login(string mail, string pass, bool rem)
        {
            return UserDAO.Instance.Login(mail, pass, rem);
        }

        public Account remember()
        {
            return UserDAO.Instance.remember();
        }
    }
}
