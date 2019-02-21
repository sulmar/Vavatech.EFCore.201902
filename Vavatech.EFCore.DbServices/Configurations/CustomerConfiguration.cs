using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using Vavatech.EFCore.FakeServices;
using Vavatech.EFCore.Models;

namespace Vavatech.EFCore.DbServices.Configurations
{
    internal class CustomerConfiguration : IEntityTypeConfiguration<Customer>
    {
        private CustomerFaker customerFaker;

        public CustomerConfiguration(CustomerFaker customerFaker)
        {
            this.customerFaker = customerFaker;
        }

        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder
               .Property(p => p.FirstName)
               .HasMaxLength(50);

            builder
                .Property(p => p.LastName)
                .HasMaxLength(50)
                .IsRequired();

            var customers = customerFaker.Generate(100);
            builder.HasData(customers);
        }
    }
}
