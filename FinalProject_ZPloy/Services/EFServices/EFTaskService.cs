﻿using FinalProject_ZPloy.Models;
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
    public class EFTaskService : ITaskService
    {

        private AppDbContext context;
        private readonly UserManager<AppUser> userManager;
        //public string UserID { get; set; }

        public EFTaskService(AppDbContext dbcontext, UserManager<AppUser> userManager)
        {
            context = dbcontext;
            this.userManager = userManager;
        }

        public void CreateTask(Models.Task task, int creatorID)
        {
            task.CreatorID = creatorID;/*userManager.GetUserId(userManager.GetUserAsync())*/
            context.Tasks.Add(task);
            context.SaveChanges();
        }

        public IEnumerable<Models.Task> GetAllTasks()
        {
            return context.Tasks;
        }

        public Models.Task GetTask(int id)
        {
            return context.Tasks.Where(t => t.TaskID == id).FirstOrDefault(t => t.TaskID == id);
        }


        public void DeleteTask(int id)
        {
            Models.Task task = context.Tasks.Where(t => t.TaskID == id).FirstOrDefault();
            context.Tasks.Remove(task);
            context.SaveChanges();

        }

        public void EditTask(Models.Task task)
        {
            task.CreatorID = 1; //not working without this line
            context.Tasks.Update(task);
            context.SaveChanges();
        }

        public Models.Task UpdateTask(Models.Task task)
        {

            Models.Task tsk = context.Tasks.Where(t => t.TaskID == task.TaskID).FirstOrDefault();
            if (tsk != null)
            {
                task.CreatorID = 1;
                tsk.Title = task.Title;
                tsk.Location = task.Location;
                tsk.Description = task.Description;
                tsk.Categories= task.Categories;
                tsk.Location = task.Location;
                tsk.Prize = task.Prize;
                tsk.Payment = task.Payment;
                context.SaveChanges();
            }
            return task;

        }
    }
}
