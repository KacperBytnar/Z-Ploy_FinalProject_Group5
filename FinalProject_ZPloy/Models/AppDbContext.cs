using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProject_ZPloy.Models
{
    public class AppDbContext : IdentityDbContext<AppUser, IdentityRole<int>, int>
    {

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) 
        {
        
        }

        //public virtual DbSet<AppUser> AppUsers { get; set; }
        public virtual DbSet<Task> Tasks { get; set; }
        public virtual DbSet<Payment> Payments { get; set; }
        public virtual DbSet<Notification> Notifications { get; set; }
        public virtual DbSet<Inbox> Inboxes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Task>()
                .HasOne<AppUser>(u => u.User)
                .WithMany(g => g.CompletedTasks)
                //.HasForeignKey(l => l.PerformerID)
                .HasForeignKey(p => p.CreatorID);
        }
    }
}
