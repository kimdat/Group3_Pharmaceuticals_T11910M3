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
using PharmaceuticalsCompany.Data;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using PharmaceuticalsCompany.Services.Career;
using PharmaceuticalsCompany.Models.Career;
using PharmaceuticalsCompany.Services.ManageCareer;
using PharmaceuticalsCompany.Services.ManageRole;
using PharmaceuticalsCompany.Services.Contact;
using PharmaceuticalsCompany.Services.Product;
using PharmaceuticalsCompany.Services.LiquidFillings;
using PharmaceuticalsCompany.Services.Tablets;
using PharmaceuticalsCompany.Services.Quote;
using ReflectionIT.Mvc.Paging;
using PharmaceuticalsCompany.Security;
namespace PharmaceuticalsCompany
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
            services.AddScoped<IManageRole, ManageRoleImpl>();
            services.AddScoped<IManageCareer, ManageCareerImpl>();
            services.AddScoped<ICareerService, CareerServiceImpl>();
            services.AddScoped<ICapsules, CapsulesServices>();
            services.AddScoped<IContact, ContactServices>();
            services.AddScoped<ITablets, TablestSevices>();
            services.AddScoped<IQuote, QuoteServices>();
            services.AddScoped<ILiquid, LiquidImpl>();
            services.AddIdentity<ApplicationUser, IdentityRole>(options=>
            {
                options.Tokens.EmailConfirmationTokenProvider = "CustomEmailConfirmation";

            })
            .AddEntityFrameworkStores<ApplicationDbContext>()
            .AddDefaultTokenProviders().AddTokenProvider<CustomEmailConfirmationTokenProvider
            <ApplicationUser>> ("CustomEmailConfirmation");
            services.Configure<CookiePolicyOptions>(options =>
            {
                // This lambda determines whether user consent for non-essential cookies is needed for a given request.
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });
           
            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(
                    Configuration.GetConnectionString("DefaultConnection")));
            
            services.AddSession();
            
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);

            services.Configure<DataProtectionTokenProviderOptions>(o => o.TokenLifespan = TimeSpan.FromMinutes(30));

            services.Configure<CustomEmailConfirmationTokenProvierOptions>(o => o.TokenLifespan=TimeSpan
            .FromDays(36500));
            services.ConfigureApplicationCookie(options => options.LoginPath = "/Admin/Login");
            services.ConfigureApplicationCookie(options => options.AccessDeniedPath = new PathString("/Admin/AccessDenied"));
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseDatabaseErrorPage();
            }
            else
            {
                app.UseStatusCodePagesWithReExecute("/Error/{0}");
               // app.UseExceptionHandler("/Home/Error");
               // app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
          //  app.UseCookiePolicy();

            app.UseAuthentication();

            app.UseSession();
            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=NotFoundError}/{id?}");
            });
        }
    }
}
