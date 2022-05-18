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
        public string URL { get; set; }

        public AccountLogInModel(SignInManager<AppUser> signInManager)
        {
            this.signInManager = signInManager;
        }

        public void OnGet(string ReturnURL)
        {
            URL = ReturnURL;
        }

        public async Task<IActionResult> OnPost(string ReturnURL)
        {
            try
            {
                var result = await signInManager.PasswordSignInAsync(loginModel.Username, loginModel.Password, loginModel.RememberMe, false);
                if (result.Succeeded)
                {
                    return RedirectToPage(ReturnURL);
                }
                else
                {
                    ModelState.AddModelError(string.Empty, "Wrong username or password. Please try again.");
                    //LoginMessage = "Wrong username or password. Please try again.";
                    return Page();
                }
            }
            catch (Exception e)
            {
                LoginMessage = e.Message;
                return Page();
            }
        }
    }
}
