using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using WebPortalAPI.Data.Migrations;

namespace WebPortalAPI.Data
{
    public class ApplicationDbContext :IdentityDbContext<ApplicationUser,ApplicationRole,  string>
    {
        public ApplicationDbContext() : base()
        {
        }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
           
        }
        public DbSet<Dashboard> Dashboards { get; set; }
        public DbSet<LandingPage> LandingPages { get; set; }
        public DbSet<FirebaseSetting> FirebaseSettings { get; set; }
        public DbSet<FileUpload> FileUploads { get; set; }
        public DbSet<Newsletter_Subscription> Newsletter_Subscriptions { get; set; }
        public DbSet<EventModel> Events { get; set; }
        public DbSet<DeviceModel> Devices { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<EventModel>().HasMany(c => c.Devices)
            .WithOne(e => e.EventToBeSend);

            builder.Entity<ApplicationUser>().HasMany(c => c.Devices)
            .WithOne(e => e.AppUser);

            //builder.Entity<ApplicationUserRole>(userRole =>
            //{
            //    userRole.HasKey(ur => new { ur.UserId, ur.RoleId });

            //    userRole.HasOne(ur => ur.Role)
            //        .WithMany(r => r.UserRoles)
            //        .HasForeignKey(ur => ur.RoleId)
            //        .IsRequired();

            //    userRole.HasOne(ur => ur.User)
            //        .WithMany(r => r.UserRoles)
            //        .HasForeignKey(ur => ur.UserId)
            //        .IsRequired();
            //});

        }


    }
}
