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
            task.PerformerID = 1;
            context.Tasks.Add(task);
            context.SaveChanges();
        }

        public IEnumerable<Models.Task> GetAllTasks()
        {
            return context.Tasks;
        }
    }
}
