using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Vavatech.EFCore.DbServices.Configurations;
using Vavatech.EFCore.Models;

namespace Vavatech.EFCore.DbServices
{
    // PM> Install-Package Microsoft.EntityFrameworkCore
    public class MyContext : DbContext
    {
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Service> Services { get; set; }

        public MyContext(DbContextOptions<MyContext> options)
            : base(options)
        {
            //this.Database.EnsureDeleted();
            // this.Database.EnsureCreated();
            this.Database.Migrate();
        }

        // PM: Install-Package Microsoft.EntityFrameworkCore.SqlServer
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            // optionsBuilder.UseSqlServer()
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // EF 6.0
            // modelBuilder.Configurations.Add(new CustomerConfiguration());
            
            modelBuilder.ApplyConfiguration(new CustomerConfiguration(new FakeServices.CustomerFaker()));

            //modelBuilder.Entity<Customer>()
            //    .Property(p => p.FirstName)
            //    .HasMaxLength(50);

            //modelBuilder.Entity<Customer>()
            //    .Property(p => p.LastName)
            //    .HasMaxLength(50)
            //    .IsRequired();

            //modelBuilder.Entity<Item>()
            //    .Property(p => p.Name)
            //    .HasMaxLength(200)
            //    .IsRequired();


                

            base.OnModelCreating(modelBuilder);

            


        }

    }
}
