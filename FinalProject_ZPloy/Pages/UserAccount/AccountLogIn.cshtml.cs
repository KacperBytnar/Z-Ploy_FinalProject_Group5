using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using FinalProject_ZPloy.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FinalProject_ZPloy.Pages.UserAccount
{
    public class AccountLogInModel : PageModel
    {
        [Required]
        public string Username { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        public string LoginMessage = "";

        private IUserService userService;

        public AccountLogInModel(IUserService service)
        {
            userService = service;
        }
        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {
                return CheckLogin();
            }
            else return Page();
        }

        private IActionResult CheckLogin()
        {
            var login = Request.Form["username"];
            var password = Request.Form["password"];

            if (userService.Login(login,password)==true)
            {
                //User User = catalog.GetUserWithLogin(login);
                //if (User.isAdmin == true)
                //{
                    // an admin
                    //HttpContext.Session.SetString("user", login);
                    return Redirect("/UserAccount/DisplayUser");
                //}
                ////normal user with a login account
                //else
                //{
                //    HttpContext.Session.SetString("normal", User.Name);
                //    return Redirect("/AllEvents/Events");
                //}
            }
            else
            {
                LoginMessage = "Invalid data!";
                return Page();
            }
        }
    }
}
