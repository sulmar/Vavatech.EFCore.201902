using System;
using System.Collections.Generic;
using Vavatech.EFCore.Models;
using Vavatech.EFCore.Models.SearchCritieras;

namespace Vavatech.EFCore.IServices
{
    public interface IOrderService 
        : IEntityService<Order>
    {
        IEnumerable<Order> Get(OrderSearchCriteria criteria);

    }
}
