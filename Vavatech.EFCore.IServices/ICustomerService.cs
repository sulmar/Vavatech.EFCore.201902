using System;
using System.Collections;
using System.Collections.Generic;
using Vavatech.EFCore.Models;

namespace Vavatech.EFCore.IServices
{
    public interface ICustomerService
    {
        IEnumerable<Customer> Get();
        Customer Get(int id);
        void Add(Customer customer);
        void Update(Customer customer);
        void Remove(int id);
    }
}
