using Core_3tier.Models;
using LOGIC.UserLogic;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core_3tier.Controllers
{
    public class UserController : Controller
    {
        private UserLogic usrlogic = new UserLogic();
        public IActionResult Index()
        {
            return View();
        }
        public async Task<string> AddUser(string username, string email, string password, int authLevelId)
        {
            var result = await usrlogic.CreateNewUser(username,email,password,authLevelId);
            if(result == true)
            {
                return "Ok";
            }
            else
            {
                return "NO";
            }
        }
        public async Task<IActionResult> _GetUser()
        {
            List<UserViewModel> userList = new List<UserViewModel>();
            var result = await usrlogic.GetAllUsers();
            if(result!= null)
            {
                foreach(var i in result)
                {
                    UserViewModel user = new UserViewModel
                    {
                        UserId = i.Id,
                        Username = i.Username,
                        AuthLevel = i.AuthLevelRefId,
                        Email = i.Email
                    };
                    userList.Add(user);
                }
            }
            return PartialView(result);
        }
    }
}
