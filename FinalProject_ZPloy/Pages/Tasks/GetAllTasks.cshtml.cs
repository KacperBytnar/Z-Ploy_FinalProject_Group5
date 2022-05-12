using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FinalProject_ZPloy.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FinalProject_ZPloy.Pages.Tasks
{
    public class GetAllTasksModel : PageModel
    {
        private ITaskService taskService;

        [BindProperty]
        public IEnumerable<Models.Task> tasks { get; set; }

        public GetAllTasksModel(ITaskService service)
        {
            taskService = service;
        }
        public void OnGet()
        {
            tasks = taskService.GetAllTasks();
        }
    }
}
