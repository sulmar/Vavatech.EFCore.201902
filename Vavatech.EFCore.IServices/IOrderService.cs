using System;
using System.Collections.Generic;
using Vavatech.EFCore.Models;

namespace Vavatech.EFCore.IServices
{
    public interface IOrderService 
        : IEntityService<Order>
    {
        IEnumerable<Order> Get(DateTime from, DateTime to);
    }
}
