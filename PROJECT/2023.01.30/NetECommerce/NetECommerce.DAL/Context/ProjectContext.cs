using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using NetECommerce.Entity.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace NetECommerce.DAL.Context
{
    public class ProjectContext:IdentityDbContext<AppUser, AppUserRole, int>
    {
        //ctor

        public DbSet<Product> Products { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("server=DESKTOP-IPMIULM\\SQLEXPRESS;database=NetCoreECommerce;Integrated Security=true;");
            }

            base.OnConfiguring(optionsBuilder);
        }

        //FakeData
        protected override void OnModelCreating(ModelBuilder builder)
        {
            //AppUser
            //AppUser appUser = new AppUser
            //{
            //    Email = "egehan.afyonlu@bilgeadam.com",
            //    UserName = "admin"
            //};

            //builder.Entity<AppUser>().HasData(appUser);

            //Product
            Product product = new Product
            {
                Id = 1,
                ProductName = "Chai",
                UnitPrice = 18,
                UnistInStock = 500,
                Description = "\"Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.",
                ImagePath = "https://www.shutterstock.com/image-vector/ui-image-placeholder-wireframes-apps-260nw-1037719204.jpg"
            };

            builder.Entity<Product>().HasData(product);

            base.OnModelCreating(builder);
        }
    }
}
