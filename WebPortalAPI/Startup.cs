﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebPortalAPI.Data;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Authentication.Cookies;
using AutoMapper;
using FirebaseAdmin;
using Google.Apis.Auth.OAuth2;

namespace WebPortalAPI
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;          
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.Configure<CookiePolicyOptions>(options =>
            {
                // This lambda determines whether user consent for non-essential cookies is needed for a given request.
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;

            });
            #region Add db context to the service
            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(
                    Configuration.GetConnectionString("DefaultConnection")));
            #endregion
            #region Add default identity user
            //services.AddDefaultIdentity<IdentityUser>()
            // .AddEntityFrameworkStores<ApplicationDbContext>();
            services.AddIdentity<ApplicationUser, ApplicationRole>()
                   .AddSignInManager<SignInManager<ApplicationUser>>()
               .AddEntityFrameworkStores<ApplicationDbContext>();
            #region Password Policy
            services.Configure<IdentityOptions>(options =>
            {
                // Password settings
                options.Password.RequireDigit = true;
                options.Password.RequiredLength = 8;
                options.Password.RequireNonAlphanumeric = false;
                options.Password.RequireUppercase = true;
                options.Password.RequireLowercase = false;
            });
            #endregion
            //.AddDefaultTokenProviders();
            #endregion
            #region  security key tag
            string securityKey = "super_long_security_key";
            #endregion

            #region Symetric security key
            var symetricSecurityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(securityKey));
            #endregion
            services.AddAuthentication().AddCookie(cfg => cfg.SlidingExpiration = true)
            .AddJwtBearer(options =>
                {
                    options.TokenValidationParameters = new TokenValidationParameters
                    {
                        #region what to validate
                        ValidateIssuer = true,
                        ValidateAudience = true,
                        ValidateIssuerSigningKey = true,
                        //set up validate data
                        ValidIssuer = "phoneapp",
                        ValidAudience = "phoneappusers",
                        IssuerSigningKey = symetricSecurityKey
                        #endregion
                    };
                });
            services.AddAutoMapper(typeof(Startup));
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Latest);
        }
        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(  IApplicationBuilder app,
                                IHostingEnvironment env,
                                ApplicationDbContext context,
                                RoleManager<ApplicationRole> roleManager,
                                UserManager<ApplicationUser> userManager)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseDatabaseErrorPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }
           
            app.UseHttpsRedirection();
            app.UseStaticFiles();
            //app.UseCookiePolicy();

            app.UseAuthentication();

            SeedDatabase.Initialize(app.ApplicationServices.GetRequiredService<IServiceScopeFactory>().CreateScope().ServiceProvider);
            FirebaseApp.Create(new AppOptions()
            {
                Credential = GoogleCredential.GetApplicationDefault(),
            });
            app.UseMvc(routes =>
            {
                #region admin
                routes.MapRoute("areaRoute", "{area:exists}/{controller=Admin}/{action=Index}/{id?}");
                #endregion
                routes.MapRoute(
                    name: "default",    
                    template: "{controller=Home}/{action=Index}/{id?}");
            });
        }

    }
}
