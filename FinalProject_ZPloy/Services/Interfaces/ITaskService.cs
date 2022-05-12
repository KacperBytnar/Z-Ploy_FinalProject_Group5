using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProject_ZPloy.Services.Interfaces
{
    public interface ITaskService
    {
        public void CreateTask(Models.Task task);
        public IEnumerable<Models.Task> GetAllTasks();
    }
}
