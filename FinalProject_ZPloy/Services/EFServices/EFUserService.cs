﻿using FinalProject_ZPloy.Models;
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

        public void CreateUser(User user)
        {
            context.Users.Add(user);
            context.SaveChanges();
        }

        public bool Login(string login, string password)
        {
            foreach (User user in GetAllUsers())
            {
                if ((user.Username == login) && (user.Password == password))
                {
                    return true;
                }
            }
            return false;
        }

        public List<User> GetAllUsers()
        {
            return context.Users.ToList();
        }
    }
}
