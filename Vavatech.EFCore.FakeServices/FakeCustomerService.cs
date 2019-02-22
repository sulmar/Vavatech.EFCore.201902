using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Vavatech.EFCore.IServices;
using Vavatech.EFCore.Models;
using Vavatech.EFCore.Models.SearchCritieras;

namespace Vavatech.EFCore.FakeServices
{
    public class FakeCustomerService : ICustomerService
    {
        private IEnumerable<Customer> customers;

        private readonly CustomerFaker customerFaker;

        public FakeCustomerService(CustomerFaker customerFaker)
        {
            this.customerFaker = customerFaker;

            customers = customerFaker.Generate(100);
        }

        public void Add(Customer customer)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Customer> Get()
        {
            return customers;
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

        public IEnumerable<Customer> Get(CustomerSearchCriteria criteria)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Customer>> GetAsync()
        {
            throw new NotImplementedException();
        }

        public Task AddAsync(Customer customer)
        {
            throw new NotImplementedException();
        }
    }
}
