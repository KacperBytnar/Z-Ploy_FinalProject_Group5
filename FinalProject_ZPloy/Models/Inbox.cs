using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProject_ZPloy.Models
{
    public class Inbox
    {
        public int InboxID { get; set; }

        // Foreign Keys
        public int UserID { get; set; }

        //  Navigation Properties
        public virtual AppUser User { get; set; }
        public virtual ICollection<Notification> Notifications {get;set;}
    }
}
