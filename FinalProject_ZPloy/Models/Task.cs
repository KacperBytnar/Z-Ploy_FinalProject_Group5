using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProject_ZPloy.Models
{
    public class Task
    {
        public Task()
        {
            //this.Users = new HashSet<AppUser>();
        }
        [Key]
        public int TaskID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string? Location { get; set; }
        public DateTime DueDate { get; set; }
        public int Prize { get; set; }
        public bool isDone { get; set; }
        // Open | In proggress | Done
        //public string State { get; set; }
         public PaymentMethod Payment { get; set; }
        public TaskCategory Categories {get;set;}

        public enum TaskCategory
        {
            Cleaning,   
            MovingServices,
            Handyman,
            Gardening
        }

        public enum PaymentMethod
        {
            Cash,
            MobilePay,
            BankTransfer,
            SecurePayment
        }


        // Foreign Keys
        [ForeignKey(nameof(CreatorID))]
        public int CreatorID { get; set; }

        //[ForeignKey(nameof(PerformerID))]
        //public int? PerformerID { get; set; }

        // Navigation Properties
        public virtual AppUser User { get; set; }
        //public virtual ICollection<AppUser> Users{ get; set; }
        public virtual ICollection<UserBidOnTask> Bids { get; set; }
    }
}
