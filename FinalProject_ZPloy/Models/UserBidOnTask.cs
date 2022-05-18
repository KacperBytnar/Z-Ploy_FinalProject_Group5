using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProject_ZPloy.Models
{
    public class UserBidOnTask
    {
        [Key]
        public int BidID { get; set; }
        public bool? isAccepted { get; set; }

        // Foreign Keys
        //[ForeignKey(nameof(TaskID))]
        //[Required]
        //public int TaskID { get; set; }
        [ForeignKey(nameof(UserID))]
        [Required]
        public int UserID { get; set; }

        // Navigation Properties
        //[ForeignKey(nameof(TaskID))]
        //public virtual Task Task { get; set; }
        //[ForeignKey(nameof(UserID))]
        public virtual AppUser User { get; set; }
    }
}
