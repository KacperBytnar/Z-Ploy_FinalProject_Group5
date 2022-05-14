using FinalProject_ZPloy.Models;
using FinalProject_ZPloy.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProject_ZPloy.Services.EFServices
{
    public class EFUserService : IUserService
    {
        private AppDbContext context;
        public EFUserService(AppDbContext userContext)
        {
            context = userContext;
        }

        public void CreateUser(AppUser user)
        {
            //context.AppUsers.Add(user);
            context.SaveChanges();
        }

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
            return new List<AppUser>(); /*context.AppUsers.ToList();*/
        }
    }
}
