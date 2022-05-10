using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProject_ZPloy.Models
{
    public class Task
    {
        public int TaskID { get; set; }
        public string Title { get; set; }
        public string? PictureName { get; set; }
        public string Location { get; set; }
        public int Prize { get; set; }
        public string PaymentMethod { get; set; }
        public bool isDone { get; set; }
        public string Category { get; set; }


        // Foreign Keys
        public int UserID { get; set; }
        // Navigation Properties
        public virtual User User { get; set; }
    }
}
