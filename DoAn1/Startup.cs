using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using DoAn1.Data;
using DoAn1.Data.Interfaces;
using DoAn1.Data.Models;
using DoAn1.Data.Repository;
using DoAn1.Mapping;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using DoAn1.Hubs;

namespace DoAn1
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


            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);

            services.AddTransient<IProductRepository, ProductRepository>();
            services.AddTransient<IProductTypeRepository, ProductTypeRepository>();

            services.AddIdentity<IdentityUser, IdentityRole>().AddEntityFrameworkStores<MerchShopDbContext>().AddDefaultTokenProviders();
            services.AddScoped<IShoppingCartService>(sp => ShoppingCartService.GetCart(sp));
            services.AddScoped<IOrderRepository, OrderRepository>();
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            services.AddMemoryCache();
            var mappingConfig = new MapperConfiguration(mc =>
            {
                mc.AddProfile(new MappingProfile());
            });

            IMapper mapper = mappingConfig.CreateMapper();
            services.AddSingleton(mapper);

            services.AddSignalR();
            //services.AddIdentity<IdentityUser, IdentityRole>(options =>
            //{
            //    options.User.RequireUniqueEmail = true;
            //    options.User.AllowedUserNameCharacters = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            //    options.Password.RequireUppercase = false;
            //})
            //.AddEntityFrameworkStores<MerchShopDbContext>();

            //Khai báo connection
            var connection = @"Server=(localdb)\mssqllocaldb;Database=DoAn1.Models;Trusted_Connection=True;ConnectRetryCount=0";
            services.AddDbContext<MerchShopDbContext>
                (options => options.UseSqlServer(connection));

            services.ConfigureApplicationCookie(options =>
            {
                options.LoginPath = "/Account/Login";
                options.AccessDeniedPath = "/Account/UnAuthorized";
            });

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, IServiceProvider serviceProvider)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseCookiePolicy();

            app.UseSignalR(routes =>
            {
                routes.MapHub<ChatHub>("/chatSignalR");
            });

            app.UseStatusCodePagesWithReExecute("/Error/{0}");

            app.UseAuthentication();

            app.UseMvc(routes =>
            {
                routes.MapAreaRoute(
                  name: "AdminArea",
                  areaName: "Admin",
                  template: "Admin/{controller=Management}/{action=Index}/{id?}"
                );

                routes.MapAreaRoute(
                  name: "SellerArea",
                  areaName: "Seller",
                  template: "Seller/{controller=SellerOrder}/{action=SellerAllOrders}/{id?}"
                );

                routes.MapRoute(
                name: "default",
                template: "{controller=HomePage}/{action=Index}/{id?}"
                );        
            });
            //DbInitializer.Seed(app);
            //DbInitializer.CreateRoles(serviceProvider).Wait();
            CreateRoles(serviceProvider).Wait();
        }
        private async Task CreateRoles(IServiceProvider serviceProvider)
        {
            //initializing custom roles
            var RoleManager = serviceProvider.GetRequiredService<RoleManager<IdentityRole>>();
            var UserManager = serviceProvider.GetRequiredService<UserManager<IdentityUser>>();
            string[] roleNames = { "Admin", "User", "Seller" };
            IdentityResult roleResult;
            foreach (var roleName in roleNames)
            {
                var roleExist = await RoleManager.RoleExistsAsync(roleName);
                if (!roleExist)
                {
                    //create the roles and seed them to the database: Question 1 
                    roleResult = await RoleManager.CreateAsync(new IdentityRole(roleName));
                }
            }
            IdentityUser user = await UserManager.FindByEmailAsync("jignesh@gmail.com");
            if (user == null)
            {
                user = new IdentityUser()
                {
                    UserName = "jignesh@gmail.com",
                    Email = "jignesh@gmail.com",
                };
                await UserManager.CreateAsync(user, "Test@123");
            }
            await UserManager.AddToRoleAsync(user, "Admin");
            IdentityUser user1 = await UserManager.FindByEmailAsync("tejas@gmail.com");
            if (user1 == null)
            {

                user1 = new IdentityUser()
                {
                    UserName = "tejas@gmail.com",
                    Email = "tejas@gmail.com",
                };
                await UserManager.CreateAsync(user1, "Test@123")
                ;
            }
            await UserManager.AddToRoleAsync(user1, "User");
            IdentityUser user2 = await UserManager.FindByEmailAsync("rakesh@gmail.com");
            if (user2 == null)
            {
                user2 = new IdentityUser()
                {
                    UserName = "rakesh@gmail.com",
                    Email = "rakesh@gmail.com",
                };
                await UserManager.CreateAsync(user2, "Test@123")
                ;
            }
            await UserManager.AddToRoleAsync(user2, "Seller");
        }
    }
}

