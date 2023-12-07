using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static DataAccess.UserDAO;
using BlogObject;
using System.Runtime.Intrinsics.Arm;
using BlogObject.Models;

namespace DataAccess.Repository
{
    public class UserRepository : IUserRepository
    {
        public bool CreateUser(UserTbl newUser)
        {
            return UserDAO.Instance.CreateUser(newUser);
        }

        public void DeleteUser(string userID)
        {
            UserDAO.Instance.DeleteUser(userID);
        }

        public List<UserTbl> GetAllUser()
        {
            return UserDAO.Instance.GetAllUser();
        }

        public string Login(string mail, string pass, bool rem)
        {
            return UserDAO.Instance.Login(mail, pass, rem);
        }

        public Account remember()
        {
            return UserDAO.Instance.remember();
        }

        public void UpdateUser(string userID, string role, string major)
        {
            UserDAO.Instance.UpdateUser(userID, role, major);
        }

        public UserTbl user(string id)
        {
            return UserDAO.Instance.user(id);
        }
    }
}
