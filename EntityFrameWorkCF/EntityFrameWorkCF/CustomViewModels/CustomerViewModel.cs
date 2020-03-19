using EntityFrameworkDBFApi.Models.entityModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EntityFrameworkDBFApi.CustomViewModels
{
    public class CustomerViewModel
    {
        public Customer _customer { get; set; }
        public Orders _orders { get; set; }
        
    }
}
