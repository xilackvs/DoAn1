using DoAn1.Data.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DoAn1.Data
{
    public static class DbInitializer
    {
        public static void Seed(IApplicationBuilder app)
        {
            using (var serviceScope = app.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<MerchShopDbContext>();

                var Hoodie = new ProductType
                {
                    Name = "Hoodie",
                    Products = new List<Product>()
                    {
                        new Product
                        {
                            ProductName = "Zero Death White Hoodie",
                            ShortDescription = "test",
                            LongDescription = "test",
                            Photo = "ZeroDeathHoodie_White.jpg",
                            Price = 39.99,
                            IsThisHot = false
                        }
                    }
                };

                var LongSleeve = new ProductType
                {
                    Name = "LongSleeve",
                    Products = new List<Product>()
                };

                var Jacket = new ProductType
                {
                    Name = "Jacket",
                    Products = new List<Product>()
                    {
                        new Product
                        {
                            ProductName = "Camo Jacket",
                            ShortDescription = "test",
                            LongDescription = "test",
                            Photo = "CamoJacket.jpg",
                            Price = 99.99,
                            IsThisHot = false
                        }
                    }
                };

                var Shirt = new ProductType
                {
                    Name = "Shirt",
                    Products = new List<Product>()
                };

                context.ProductTypes.Add(Hoodie);
                context.ProductTypes.Add(LongSleeve);
                context.ProductTypes.Add(Jacket);
                context.ProductTypes.Add(Shirt);

                context.SaveChanges();
            }
        }
        //public static void Seed(this ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<ProductType>().HasData(
        //            new ProductType { Id = 1, Name = "Hoodie", Products = new List<Product> {
        //                new Product
        //                {
        //                    ProductName = "Zero Death White Hoodie",
        //                    ShortDescription = "test",
        //                    LongDescription = "test",
        //                    Photo = "ZeroDeathHoodie_White.jpg",
        //                    Price = 39.99,
        //                    IsThisHot = false
        //                }
        //            } },
        //            new ProductType { Id = 2, Name = "Long Sleeve" },
        //            new ProductType { Id = 3, Name = "Shirt"},
        //            new ProductType { Id = 4, Name = "Jacket"},
        //            new ProductType { Id = 5, Name = "Hat"}
        //    );

        //    //modelBuilder.Entity<Product>().HasData(
        //    //    new Product
        //    //    {
        //    //        Id = 1,
        //    //        ProductName = "Zero Death White Hoodie",
        //    //        ShortDescription = "test",
        //    //        LongDescription = "test",
        //    //        Photo = "ZeroDeathHoodie_White.jpg",
        //    //        Price = 39.99,
        //    //        IsThisHot = false,
        //    //        ProductTypeID = 1,
        //    //    });
        //}

        public static async Task CreateRoles(IServiceProvider serviceProvider)
        {
            var RoleManager = serviceProvider.GetRequiredService<RoleManager<IdentityRole>>();
            var UserManager = serviceProvider.GetRequiredService<UserManager<IdentityUser>>();
            string[] roleNames = { "Admin", "User", "HR" };
            IdentityResult roleResult;

            foreach (var roleName in roleNames)
            {
                var roleExist = await RoleManager.RoleExistsAsync(roleName);
                if (!roleExist)
                {
                    roleResult = await RoleManager.CreateAsync(new IdentityRole(roleName));
                }
            }

            IdentityUser user = await UserManager.FindByEmailAsync("dinhhai1@gmail.com");
            if (user == null)
            {
                user = new IdentityUser()
                {
                    UserName = "dinhhai1@gmail.com",
                    Email = "dinhhai1@gmail.com",
                };
                await UserManager.AddToRoleAsync(user, "Admin");
            }

            IdentityUser user1 = await UserManager.FindByEmailAsync("dinhai2@gmail.com");
            if (user1 == null)
            {
                user1 = new IdentityUser()
                {
                    UserName = "dinhai1@gmail.com",
                    Email = "dinhai1@gmail.com",
                };
                await UserManager.CreateAsync(user1, "Test@123")
                ;
            }
            await UserManager.AddToRoleAsync(user1, "User");
            IdentityUser user2 = await UserManager.FindByEmailAsync("dinhai3@gmail.com");
            if (user2 == null)
            {
                user2 = new IdentityUser()
                {
                    UserName = "dinhai2@gmail.com",

                    Email = "dinhai2@gmail.com",
                };
                await UserManager.CreateAsync(user2, "Test@123")
                ;
            }
            await UserManager.AddToRoleAsync(user2, "HR");
        }
    }
}
