using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FinalProject_ZPloy.Models;
using FinalProject_ZPloy.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FinalProject_ZPloy.Pages.UserAccount
{
    public class CreateUserModel : PageModel
    {
        public User User { get; set; }
        public string registerMessage { get; set; }
        [BindProperty]
        public string ConfirmPassword { get; set; }

        private IUserService userService;
        public CreateUserModel(IUserService service)
        {
            userService = service;
        }
        public void OnGet()
        {
        }
    }
}
