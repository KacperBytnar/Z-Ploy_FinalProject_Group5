using FinalProject_ZPloy.Models;
using FinalProject_ZPloy.Services.Interfaces;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Security.Principal;
using System.Threading.Tasks;

namespace FinalProject_ZPloy.Services.EFServices
{
    public class EFUserService : IUserService
    {
        private AppDbContext context;
        private readonly UserManager<AppUser> userManager;
        public EFUserService(AppDbContext userContext, UserManager<AppUser> userManager)
        {
            context = userContext;
            this.userManager = userManager;
        }

        public void CreateUser(AppUser user)
        {
            //context.AppUsers.Add(user);
            context.SaveChanges();
        }

        //public static string GetUserId(this IPrincipal principal)
        //{
        //    var claimsIdentity = (ClaimsIdentity)principal.Identity;
        //    var claim = claimsIdentity.FindFirst(System.Security.Claims.ClaimTypes.NameIdentifier);
        //    return claim.Value;
        //}

        public bool ValidateUser(string login, string password)
        {
            //foreach (AppUser user in GetAllUsers())
            //{
            //    if ((user.Username == login) && (user.Password == password))
            //    {
            //        return true;
            //    }
            //}
            return false;
        }

        public List<AppUser> GetAllUsers()
        {
            return userManager.Users.ToList();
        }

        public AppUser GetUserById(int id)
        {
            return context.Users.Where(t => t.Id == id).FirstOrDefault(t => t.Id == id);
        }
    }
}
