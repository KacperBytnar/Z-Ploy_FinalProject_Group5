using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProject_ZPloy.Services.Interfaces
{
    public interface ITaskService
    {
        void CreateTask(Models.Task task, int creatorID);

        IEnumerable<Models.Task> GetAllTasks();

        Models.Task GetTask(int id);

        void DeleteTask(int id);

        void EditTask(Models.Task task);

        Models.Task UpdateTask(Models.Task task);

    }
}
