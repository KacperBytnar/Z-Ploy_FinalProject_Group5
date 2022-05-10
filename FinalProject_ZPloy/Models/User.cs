using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProject_ZPloy.Models
{
    public class User
    {
        public int UserID { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string picture { get; set; }
        public string description { get; set; }

        // Navigation Properties
        public  virtual ICollection<Task> CompletedTasks { get; set; }
        //public virtual ICollection<Task> CreatedTasks { get; set; }
    }
}
