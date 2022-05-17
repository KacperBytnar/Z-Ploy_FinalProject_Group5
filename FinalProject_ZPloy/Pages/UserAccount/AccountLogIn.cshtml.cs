using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using FinalProject_ZPloy.Models;
using FinalProject_ZPloy.Services.Interfaces;
using FinalProject_ZPloy.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FinalProject_ZPloy.Pages.UserAccount
{
    public class AccountLogInModel : PageModel
    {  
        [BindProperty]
        public LoginViewModel loginModel { get; set; }
        public string LoginMessage = "";

        //private IUserService userService;
        private readonly SignInManager<AppUser> signInManager;

        public AccountLogInModel(SignInManager<AppUser> signInManager)
        {
            this.signInManager = signInManager;
        }
        public void OnGet()
        {
        }

        public async Task<IActionResult> OnPost()
        {
            try
            {
                var result = await signInManager.PasswordSignInAsync(loginModel.Username, loginModel.Password, loginModel.RememberMe, false);
                if (result.Succeeded)
                {
                    return RedirectToPage("/UserAccount/DisplayUser");
                }
                else
                {
                    ModelState.AddModelError(string.Empty, "Invalid data!");
                    LoginMessage = "Invalid data!";
                    return Page();
                }
            }
            catch (Exception e)
            {
                LoginMessage = e.Message;
                return Page();
            }

            //var login = Request.Form["username"];
            //var password = Request.Form["password"];

            //if (userService.ValidateUser(login,password)==true)
            //{
            //    //User User = catalog.GetUserWithLogin(login);
            //    //if (User.isAdmin == true)
            //    //{
            //        // an admin
            //        //HttpContext.Session.SetString("user", login);
            //        return Redirect("/UserAccount/DisplayUser");
                //}
                ////normal user with a login account
                //else
                //{
                //    HttpContext.Session.SetString("normal", User.Name);
                //    return Redirect("/AllEvents/Events");
                //}
        }
    }
}
