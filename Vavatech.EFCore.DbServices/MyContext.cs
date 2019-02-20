using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
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

        }

        // PM: Install-Package Microsoft.EntityFrameworkCore.SqlServer
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            // optionsBuilder.UseSqlServer()
        }

    }
}
