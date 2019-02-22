using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Vavatech.EFCore.IServices;
using Vavatech.EFCore.Models;

namespace Vavatech.EFCore.WebService.Controllers
{
    [Route("api/[controller]")]
    public class CustomersController : ControllerBase
    {
        private readonly ICustomerService customerService;

        public CustomersController(ICustomerService customerService)
        {
            this.customerService = customerService;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Customer>>> Get([FromServices] ISenderService senderService)
        {
            var customers = await customerService.GetAsync().ConfigureAwait(false);

            ISenderService sender = this.HttpContext.RequestServices.GetService(typeof(ISenderService)) as ISenderService;

            senderService.Send($"Pobrano {customers.Count()} klientów");

            return Ok(customers);
        }

        [HttpPost]
        public ActionResult Post([FromBody] Customer customer)
        {
            customerService.Add(customer);

            return Ok();
        }

        [HttpDelete]
        [Route("{id}")]
        public ActionResult Delete(int id)
        {
            customerService.Remove(id);

            return Ok();
        }

        [HttpPut]
        [Route("{id}")]
        public ActionResult Put(int id, [FromBody] Customer customer)
        {
            customerService.Update(customer);

            return Ok();
        }


    }
}
