using Entity_Layer;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data_Layer
{
   public class SessionDbContext : IdentityDbContext<UserMaster>
    {
        public SessionDbContext(DbContextOptions<SessionDbContext> options) : base(options)
        {

        }
        /// <summary>
        /// Seed and create DbSet for all Dating App classes
        /// </summary>

        public DbSet<Create_NewSession> CreateNewSession { get; set; }
        public DbSet<Admin_Registration> AdminRegistration { get; set; }
        public DbSet<Session_Logs> SessionLogs { get; set; }
        public DbSet<UserMaster> UserMaster { get; set; }
       

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Create_NewSession>().HasKey(x => x.PrimaryID);
            builder.Entity<Admin_Registration>().HasKey(x => x.PrimaryID);
            builder.Entity<Session_Logs>().HasKey(x => x.PrimaryID);
            base.OnModelCreating(builder);
        }
    }
}
