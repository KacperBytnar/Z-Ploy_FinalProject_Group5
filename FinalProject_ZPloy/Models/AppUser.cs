using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProject_ZPloy.Models
{
    public class AppUser : IdentityUser<int>
    {
        public override int Id { get; set; }
        public string XDUsername { get; set; }
        public string lolPassword { get; set; }
        public string? Gender { get; set; }
        public int? Age { get; set; }
        public string? Picture { get; set; }
        public string? Description { get; set; }
        //public string? Email { get; set; }


        // Navigation Properties
        public virtual ICollection<Task> CompletedTasks { get; set; }
        //public virtual ICollection<Task> CreatedTasks { get; set; }
    }
}
