using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProject_ZPloy.Models
{
    public class BoardOfTasks
    {
        public int BoardOfTasksID { get; set; }
        public DateTime PostTime { get; set; }
        public virtual ICollection<Task> Tasks { get; set; }
    }
}
