using Microsoft.AspNetCore.Identity;
using RYI_TOTE.Core.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using System.Xml.Linq;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace RYI_TOTE.DAL.Data
{
    public class RYI_TOTEContext : DbContext
    { 
        public RYI_TOTEContext()
        {
        }

      

        public DbSet<Assignment> Assignments { get; set; }
        public DbSet<BookingCall> BookingCalls { get; set; }
        public DbSet<Feeback> Feebacks { get; set; }
        public DbSet<MenteeApplication> MenteeApplications { get; set; }
        public DbSet<MenteePlan> MenteePlans { get; set; }
        public DbSet<MentorApplication> MentorApplications { get; set; }
        public DbSet<MentorApplicationAnswer> MentorApplicationAnswers { get; set; }
        public DbSet<MentorApplicationQuestion> MentorApplicationQuestions { get; set; }
        public DbSet<MentorPlan> MentorPlans { get; set; }
        public DbSet<Mentorship> Mentorships { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<Notification> Notifications { get; set; }
        public DbSet<Session> Sessions { get; set; }
        public DbSet<Skill> Skills { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            if (!options.IsConfigured)
                options.UseSqlServer(
                    "server =(local); database = RYI_TOTE;uid=sa;pwd=12345; TrustServerCertificate=True");
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //modelBuilder.Entity<Feeback>()
            //    .HasMany(u => u.UserRoles)
            //    .WithOne(r => r.User)
            //    .HasForeignKey(r => r.MentorshipId)
            //    .IsRequired();

            


        }
    }
}
