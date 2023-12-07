using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static DataAccess.UserDAO;
using BlogObject;
using BlogObject.Models;

namespace DataAccess.Repository
{
    public interface IUserRepository
    {
        public string Login(string mail, string pass, bool rem);
        public Account remember();
        public UserTbl user(string id);
        public bool CreateUser(UserTbl newUser);
        public void DeleteUser(string userID);
        public List<UserTbl> GetAllUser();
        public void UpdateUser(string userID, string role, string major);
    }
}
