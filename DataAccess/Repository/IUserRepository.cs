using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static DataAccess.UserDAO;
using BlogObject;

namespace DataAccess.Repository
{
    public interface IUserRepository
    {
        public bool Login(string mail, string pass, bool rem);
        public Account remember();
        public User user(string id);
        public bool CreateUser(User newUser);
    }
}
