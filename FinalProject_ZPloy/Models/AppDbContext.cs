using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProject_ZPloy.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) 
        {
        
        }

        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Task> Tasks { get; set; }
        public virtual DbSet<Payment> Payments { get; set; }
        public virtual DbSet<BoardOfTasks> ActiveTasks { get; set; }
        public virtual DbSet<Notification> Notifications { get; set; }
        public virtual DbSet<Inbox> Inboxes { get; set; }
    }
}
