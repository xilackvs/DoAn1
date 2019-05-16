using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using DoAn1.Data;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;

namespace DoAn1.Data.Models
{
    public class MerchShopDbContext : IdentityDbContext<IdentityUser>
    {
        public MerchShopDbContext(DbContextOptions<MerchShopDbContext> options) : base(options)
        { }

        public DbSet<ProductType> ProductTypes { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<ShoppingCartItem> ShoppingCartItems { get; set; }


        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Seed();
        //    //modelBuilder.Entity<ProductType>().HasData(
        //    //        new ProductType { Id = 1, Name = "Hoodie" },
        //    //        new ProductType { Id = 2, Name = "Long Sleeve" });

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
        //    //        ProductTypeID = 1
        //    //    });
        //}
    }
}
