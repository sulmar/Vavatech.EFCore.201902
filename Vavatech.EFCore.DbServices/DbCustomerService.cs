using System;
using System.Collections.Generic;
using System.Linq;
using Vavatech.EFCore.IServices;
using Vavatech.EFCore.Models;

namespace Vavatech.EFCore.DbServices
{
    public class DbCustomerService : ICustomerService
    {
        private readonly MyContext context;

        public DbCustomerService(MyContext context)
        {
            this.context = context;
        }

        public void Add(Customer customer)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Customer> Get()
        {
            return context.Customers.ToList();
        }

        public Customer Get(int id)
        {
            throw new NotImplementedException();
        }

        public void Remove(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Customer customer)
        {
            throw new NotImplementedException();
        }
    }
}
