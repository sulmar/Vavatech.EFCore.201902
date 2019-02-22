using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using Vavatech.EFCore.Models;
using Vavatech.EFCore.Models.SearchCritieras;

namespace Vavatech.EFCore.IServices
{
    

    public interface ICustomerService
    {
        IEnumerable<Customer> Get();
        Customer Get(int id);
        IEnumerable<Customer> Get(CustomerSearchCriteria criteria);

        void Add(Customer customer);
        void Update(Customer customer);
        void Remove(int id);

        Task<IEnumerable<Customer>> GetAsync();
        Task AddAsync(Customer customer);
       

    }
}
