using DAL.Entities;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOGIC.UserLogic
{
    public class UserLogic
    {
        private IUser _user = new DAL.Functions.UserFunctions();

        public async Task<bool> CreateNewUser(string username, string email, string password, int authLevelId)
        {
            try
            {
                var result = await _user.AddUser(username,email,password,authLevelId);
                if (result.Id > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch
            {
                return false;
            }
        }
        public async Task<List<User>> GetAllUsers()
        {
            List<User> users = await _user.GetAllUsers();
            return users;
        }
    }
}
