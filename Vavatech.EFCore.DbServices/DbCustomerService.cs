using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using Vavatech.EFCore.IServices;
using Vavatech.EFCore.Models;
using Vavatech.EFCore.Models.SearchCritieras;

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

        public IEnumerable<Customer> Get(string lastname)
        {
            // GET: http://domain.com/customers?lastname=Marcin;DROP TABLE 

            // select * from dbo.customers where LastName = 'Marcin OR 1=1';

            string sql = $"select * from dbo.customers where LastName = '{lastname}'";

            return context.Customers.FromSql(sql);

        }

        public IEnumerable<Customer> Get(CustomerSearchCriteria criteria)
        {
            IQueryable<Customer> query = context.Customers;

            if (!string.IsNullOrEmpty(criteria.FirstName))
            {
                query = query.Where(c => c.FirstName == criteria.FirstName);
            }

            if (!string.IsNullOrEmpty(criteria.LastName))
            {
                query = query.Where(c => c.LastName == criteria.LastName);
            }
                    
            query = query.Where(c => c.IsDeleted == true);

            var customers = query.ToList();

                    





            return customers;

        }
    }
}
