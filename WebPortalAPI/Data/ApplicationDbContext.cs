using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using WebPortalAPI.Data.Migrations;

namespace WebPortalAPI.Data
{
    public class ApplicationDbContext :IdentityDbContext<ApplicationUser,ApplicationRole,string>
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
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }


    }
}
