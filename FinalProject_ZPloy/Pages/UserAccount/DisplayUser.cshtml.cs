using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FinalProject_ZPloy.Common;
using FinalProject_ZPloy.Models;
using FinalProject_ZPloy.Services.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FinalProject_ZPloy.Pages.UserAccount
{
    [Authorize]
    public class DisplayUserModel : PageModel
    {
        [BindProperty]
        public List<AppUser> users { get; set; }
        private IUserService userService;
        [BindProperty]
        public int UserID { get; set; }
        public DisplayUserModel(IUserService service)
        {
            userService = service; 
        }
        
        public void OnGet()
        {
            users = userService.GetAllUsers();
            UserID = User.GetUserId();
        }
    }
}
