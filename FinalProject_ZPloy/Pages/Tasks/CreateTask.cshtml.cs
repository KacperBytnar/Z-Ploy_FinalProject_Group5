using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FinalProject_ZPloy.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FinalProject_ZPloy.Pages.Tasks
{
    public class CreateTaskModel : PageModel
    {
        IUserService userService;
        ITaskService taskService;

        [BindProperty]
        public Models.Task task { get; set; }

        public CreateTaskModel(ITaskService tService)
        {
            taskService = tService;

        }

        public IActionResult OnGet()
        {
            return Page();
        }
        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            taskService.CreateTask(task);
            return RedirectToPage("GetAllTasks");
        }
    }
}
