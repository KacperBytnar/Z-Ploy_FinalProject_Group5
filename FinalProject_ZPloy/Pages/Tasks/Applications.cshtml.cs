using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FinalProject_ZPloy.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FinalProject_ZPloy.Pages.Tasks
{
    public class ApplicationsModel : PageModel
    {

        ITaskService taskService;

        [BindProperty]
        public Models.Task Task { get; set; }
        public ApplicationsModel(ITaskService service)
        {
            taskService = service;
        }
        public IActionResult OnGet(int id)
        {
            Task = taskService.GetTask(id);
            return Page();
        }
    }
}
