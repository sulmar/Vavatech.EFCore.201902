using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
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
            Trace.WriteLine(context.Entry(customer).State);
            
            context.Customers.Add(customer);

            Trace.WriteLine(context.Entry(customer).State);

            context.SaveChanges();

            Trace.WriteLine(context.Entry(customer).State);

            customer.FirstName = "Ala";

            Trace.WriteLine(context.Entry(customer).State);

            context.SaveChanges();

            Trace.WriteLine(context.Entry(customer).State);

        }

        public IEnumerable<Customer> Get()
        {
            return context.Customers.AsNoTracking().ToList();
        }

        public Customer Get(int id)
        {
            throw new NotImplementedException();
        }

        public void Remove(int id)
        {
            //  Customer customer = context.Customers.Find(id);

            Customer customer = new Customer { Id = id };

            // context.Customers.Attach(customer);            

            Trace.WriteLine(context.Entry(customer).State);

            context.Customers.Remove(customer);

            Trace.WriteLine(context.Entry(customer).State);

            context.SaveChanges();

            Trace.WriteLine(context.Entry(customer).State);
        }

        public void Update(Customer customer)
        {

            //context.Customers.Update(customer);

            //context.SaveChanges();


            //Trace.WriteLine(context.Entry(customer).State);

            //context.Customers.Attach(customer);

            //Trace.WriteLine(context.Entry(customer).State);

            //context.Entry(customer).State = EntityState.Modified;

            //Trace.WriteLine(context.Entry(customer).State);

            //context.SaveChanges();

            //Trace.WriteLine(context.Entry(customer).State);

            Trace.WriteLine(context.Entry(customer).State);
            Customer customerDb = context.Customers.Find(customer.Id);

            Trace.WriteLine(context.Entry(customerDb).State);

            customerDb.FirstName = customer.FirstName;
            customerDb.LastName = customer.LastName;

            foreach (var property in context.Entry(customerDb).Properties)
            {
                Trace.WriteLine($"{property.Metadata.Name} {property.IsModified} {property.OriginalValue} -> {property.CurrentValue}");
            }

            Trace.WriteLine(context.Entry(customerDb).State);

            context.SaveChanges();

            Trace.WriteLine(context.Entry(customerDb).State);
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

        public async Task<IEnumerable<Customer>> GetAsync()
        {
            return await context.Customers.ToListAsync();
        }

        public async Task AddAsync(Customer customer)
        {
            await context.Customers.AddAsync(customer);

            await context.SaveChangesAsync();
        }
    }
}
