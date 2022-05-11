using FinalProject_ZPloy.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProject_ZPloy.Services.Interfaces
{
    public interface IUserService
    {
        public List<User> GetAllUsers();
        public void CreateUser(User user);
    }
}
