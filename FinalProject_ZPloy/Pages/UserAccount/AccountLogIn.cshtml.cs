using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using FinalProject_ZPloy.Services.Interfaces;
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
    }
}
