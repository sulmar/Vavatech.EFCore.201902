using System;
using System.Collections.Generic;

namespace Vavatech.EFCore.Models
{
    public class Order : Base
    {
        public int Id { get; set; }
        public DateTime CreateDate { get; set; }
        public Customer Customer { get; set; }
        public IEnumerable<OrderDetail> Details { get; set; }
        public OrderStatus Status { get; set; }
    }

    


}
