using FinalProject_ZPloy.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Threading.Tasks;

namespace FinalProject_ZPloy.Services.Interfaces
{
    public interface IUserService
    {
        public List<AppUser> GetAllUsers();
        public void CreateUser(AppUser user);
        public bool ValidateUser(string login, string password);
        public AppUser GetUserById(int id);
    }
}
