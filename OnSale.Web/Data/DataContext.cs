﻿using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using OnSale.Common.Entities;
using OnSale.Web.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnSale.Web.Data
{
    public class DataContext: IdentityDbContext<User>
    {
        public DataContext(DbContextOptions<DataContext> options): base(options)
        {

        }
        public DbSet<Country> Countries { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Order> Orders { get; set; }

        public DbSet<OrderDetail> OrderDetails { get; set; }

        public DbSet<Product> Products { get; set; }

        public DbSet<ProductImage> ProductImages { get; set; }




        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Country>()
            .HasIndex(t => t.Name)
            .IsUnique();

            modelBuilder.Entity<Department>()
           .HasIndex(t => t.Name)
           .IsUnique();

            modelBuilder.Entity<City>()
           .HasIndex(t => t.Name)
           .IsUnique();
            
            modelBuilder.Entity<Category>()
             .HasIndex(t => t.Name)
             .IsUnique();

            modelBuilder.Entity<Product>()
              .HasIndex(t => t.Name)
              .IsUnique();


        }

    }
}
