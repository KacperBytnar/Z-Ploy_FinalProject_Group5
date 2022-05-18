using FinalProject_ZPloy.Models;
using FinalProject_ZPloy.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProject_ZPloy.Services.EFServices
{
    public class EFTaskService : ITaskService
    {

        private AppDbContext context;

        public EFTaskService(AppDbContext dbcontext)
        {
            context = dbcontext;
        }

        public void CreateTask(Models.Task task)
        {
            task.CreatorID = 1;
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
