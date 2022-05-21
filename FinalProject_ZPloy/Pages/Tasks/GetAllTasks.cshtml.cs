using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FinalProject_ZPloy.Common;
using FinalProject_ZPloy.Services.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FinalProject_ZPloy.Pages.Tasks
{
    [Authorize]
    public class GetAllTasksModel : PageModel
    {
        private ITaskService taskService;
        public IBidService bidService;

        [BindProperty]
        public IEnumerable<Models.Task> tasks { get; set; }

        [BindProperty]
        public int loggedUser { get; set;}
        public bool loggerUserAppliedForTheTask{ get; set; }

        public GetAllTasksModel(ITaskService tservice, IBidService bService)
        {
            taskService = tservice;
            bidService = bService;
        }
        // check here whether logged user is creator and display stuff based on that 
        // maybe just get task id instead of bool 
        public void OnGet()
        {
            loggedUser = User.GetUserId();
            tasks = taskService.GetAllTasks();
        }
    }
}
