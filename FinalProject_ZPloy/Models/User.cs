using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProject_ZPloy.Models
{
    public class User
    {
        public int UserID { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public int? Age { get; set; }
        public string? Picture { get; set; }
        public string? Description { get; set; }
        public string? Email { get; set; }


        // Navigation Properties
        public virtual ICollection<Task> CompletedTasks { get; set; }
        //public virtual ICollection<Task> CreatedTasks { get; set; }
    }
}
