using System;
using System.Collections.Generic;
using System.Text;

namespace Vavatech.EFCore.Models.SearchCritieras
{
    public abstract class SearchCriteria : Base
    {

    }

    public class CustomerSearchCriteria : SearchCriteria
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }

    public class OrderSearchCriteria : SearchCriteria
    {
        public Period Period { get; set; }
        public Customer Customer { get; set; }
        public OrderStatus Status { get; set; }
        public bool Active { get; set; }
    }

    public struct Period
    {
        public DateTime? From { get; set; }
        public DateTime? To { get; set; }

    }
}
