using DAL.DataContext;
using DAL.Entities;
using DAL.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Functions
{
    public class UserFunctions : IUser
    {
        //Add
        public async Task<User> AddUser(string username, string email, string password,int authLevelId)
        {
            User usr = new User
            {
                Email = email,
                Password = password,
                Username = username,
                AuthLevelRefId = authLevelId
            };
            using (var context = new DatabaseContext(DatabaseContext.ops.dbOptions))
            {
                await context.Users.AddAsync(usr);
                await context.SaveChangesAsync();
            }
            return usr;
        }
        //GetAll usr
        public async Task<List<User>> GetAllUsers()
        {
            List<User> usr = new List<User>();
            using (var context = new DatabaseContext(DatabaseContext.ops.dbOptions))
            {
                usr = await context.Users.ToListAsync();
               
            }
            return usr;
        }
    }
}
