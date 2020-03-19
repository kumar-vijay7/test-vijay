using System;
using System.Collections.Generic;

namespace EntityFrameworkDBFApi.Models.entityModels
{
    public partial class Customer
    {
        public Customer()
        {
            Orders = new HashSet<Orders>();
        }

        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
        public string CustomerPhone { get; set; }
        public string CustomerEmail { get; set; }
        public string CustomerAddresss { get; set; }

        public virtual ICollection<Orders> Orders { get; set; }
    }
}
