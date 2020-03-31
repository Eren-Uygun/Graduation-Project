using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing.Matching;
using Microsoft.AspNetCore.Server.IIS;
using Microsoft.CodeAnalysis;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Microsoft.Extensions.FileSystemGlobbing.Internal.Patterns;
using Microsoft.Extensions.Hosting;
using Newtonsoft.Json;
using PharmaceuticalWarehouseManagementSystem.DAL.Context;
using PharmaceuticalWarehouseManagementSystem.ENTITY.Entity;
using PharmaceuticalWarehouseManagementSystem.INFRASTRUCTURE.Repository.Abstract;
using PharmaceuticalWarehouseManagementSystem.INFRASTRUCTURE.Repository.Concrete;
using PharmaceuticalWarehouseManagementSystem.KERNEL;
using PharmaceuticalWarehouseManagementSystem.KERNEL.Enum;
using PharmaceuticalWarehouseManagementSystem.UI.Models;

namespace PharmaceuticalWarehouseManagementSystem.UI
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
            
        }
        //InvalidOperationException: No authenticationScheme was specified, and there was no DefaultChallengeScheme found. The default schemes can be set using either AddAuthentication(string defaultScheme) or AddAuthentication(Action<AuthenticationOptions> configureOptions).

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
         
            services.AddDbContext<ProjectContext>(options => options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));

           


            services.AddControllersWithViews();
            services.AddRazorPages();
           
          

          

           

            services.AddIdentity<IdentityUser, IdentityRole>(options=>
                {
                    options.SignIn.RequireConfirmedEmail = false;
                    options.SignIn.RequireConfirmedAccount = false;
                    options.SignIn.RequireConfirmedPhoneNumber = false;
                    options.User.RequireUniqueEmail = false;


                })
                .AddEntityFrameworkStores<ProjectContext>()
                .AddDefaultTokenProviders();

            services.Configure<PasswordHasherOptions>(options =>
            {
                options.CompatibilityMode = PasswordHasherCompatibilityMode.IdentityV3;
            });


            services.AddScoped<ICategoryRepository, EfCategory>();
            services.AddScoped<ICustomerRepository, EfCustomer>();
            services.AddScoped<IEmployeeRepository, EfEmployee>();
            services.AddScoped<IOrderDetailRepository, EfOrderDetail>();
            services.AddScoped<IOrderRepository, EfOrder>();
            services.AddScoped<IProductRepository, EfProduct>();
            services.AddScoped<IShipperRepository, EfShipper>();
            services.AddScoped<ISupplierRepository, EfSupplier>();


            services.AddAuthentication(Options =>
                {
                    Options.DefaultAuthenticateScheme = CookieAuthenticationDefaults.AuthenticationScheme;
                    Options.DefaultSignInScheme = CookieAuthenticationDefaults.AuthenticationScheme;
                })
                .AddCookie(options =>
                {
                    options.Cookie.Name = "Cookie1";
                    options.LoginPath = "/Account/Login/";
                });

     
            services.AddSession();



            services.AddMvc(options => { options.EnableEndpointRouting = false; });




        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
            }
            app.UseCookiePolicy();
            app.UseStaticFiles();
            app.UseRouting();
            app.UseAuthentication();
            app.UseAuthorization();
            app.UseSession();
            
            
            app.UseMvc(routes =>
            {
                routes.MapAreaRoute( 
                        name: "MyAdminArea",
                        areaName: "Admin",
                        template: "Admin/{controller=Category}/{action=List}/{id?}");

                routes.MapAreaRoute( 
                    name: "MyUserArea",
                    areaName: "User",
                    template: "User/{controller=Category}/{action=List}/{id?}");
                    
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Account}/{action=Login}");

                routes.MapRoute(
                    name: "Admin",
                    template: "{Areas=Admin}/{Controller=Category}/{Action=List}");

                routes.MapRoute(
                    name:"User",
                    template:"{Areas=User}/{Controller=Category}/{Action=List}");
            });
        } 
    }
}
