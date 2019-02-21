using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using Vavatech.EFCore.DbServices;
using Vavatech.EFCore.FakeServices;
using Vavatech.EFCore.IServices;

namespace Vavatech.EFCore.ConsoleClient
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }


        static void GenerateCustomers()
        {
            IServiceCollection services = new ServiceCollection();
            services.AddScoped<ICustomerService, DbCustomerService>();
            string connectionstring = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=MyEfCoreDb;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            services.AddDbContext<MyContext>(options => options.UseSqlServer(connectionstring));



            ICustomerService customerService = new FakeCustomerService(new CustomerFaker());

            var customers = customerService.Get();

            
            
        }
    }
}
