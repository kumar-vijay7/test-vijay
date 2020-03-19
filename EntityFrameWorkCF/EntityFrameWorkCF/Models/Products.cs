using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EntityFrameworkDBFApi.Models.entityModels
{
    public partial class Products
    {
        public Products()
        {
            Orders = new HashSet<Orders>();
        }
        [Key]
        public int ProductId { get; set; }
        public string ProductName { get; set; }

        public virtual ICollection<Orders> Orders { get; set; }
    }
}
