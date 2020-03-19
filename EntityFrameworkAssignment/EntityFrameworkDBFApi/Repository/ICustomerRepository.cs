using EntityFrameworkDBFApi.CustomViewModels;
using EntityFrameworkDBFApi.Models.entityModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EntityFrameworkDBFApi.Repository
{
  public  interface ICustomerRepository
    {
        public  Task<List<Customer>> GetAllData();
        public  Task<List<Customer>> SingleData(int id);

        public  Task<bool> InsertData(CustomerViewModel cust);

        public  Task<bool> UpdateData(CustomerViewModel cust);

        public Task<bool> DeleteData(int id);

    }
}
