using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class UserRepository : IUserRepository
    {
        public string img()
        {
            return UserDAO.Instance.img();
        }

        public bool Login(string mail, string pass)
        {
            return UserDAO.Instance.Login(mail, pass);
        }
    }
}
