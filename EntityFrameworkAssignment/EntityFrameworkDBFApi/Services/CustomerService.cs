using EntityFrameworkDBFApi.CustomViewModels;
using EntityFrameworkDBFApi.Models.entityModels;
using EntityFrameworkDBFApi.Repository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EntityFrameworkDBFApi.Services
{
    public class CustomerService : ICustomerRepository
    {
        /// <summary>
        /// This method delete the the particular data
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Boolean</returns>
        public async Task<bool> DeleteData(int id)
        {
            try
            {
                using (var dbContext = new EcommerceDBContext())
                {
                    var response = dbContext.Customer.Include("Orders").First(customer => customer.CustomerId == id);
                    dbContext.Customer.Remove(response);
                    var deleteresponse = await dbContext.SaveChangesAsync();
                    if (deleteresponse > 0)
                        return true;
                    else
                        return false;
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        /// <summary>
        /// Getting all the information about customer and order
        /// </summary>
        /// <returns>list of customer and order</returns>
        public async  Task<List<Customer>> GetAllData()
        {

            try
            {
                using (var dbContext = new EcommerceDBContext())
                {
                    var DataResponse =await dbContext.Customer.Include("Orders").Select(customerOrder => customerOrder).ToListAsync();
                    return DataResponse;
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
           
        }


        /// <summary>
        /// Inserting new records
        /// </summary>
        /// <param name="cust is the object of CustomerViewModel "></param>
        /// <returns>boolean</returns>
        public async Task<bool> InsertData(CustomerViewModel cust)
        {
            try
            {
                using (var dbContext = new EcommerceDBContext())
                {
                    dbContext.Customer.Add(cust._customer);
                    dbContext.Orders.Add(cust._orders);
                    var response = await dbContext.SaveChangesAsync();
                    if (response > 0)
                        return true;
                    else
                        return false;
                }


            }
            catch (Exception ex)
            {

                    throw ex;
            }
        }

        /// <summary>
        /// This method getting the information of the particular Customer
        /// </summary>
        /// <param name="id"></param>
        /// <returns>List Customer</returns>
        public async Task<List<Customer>> SingleData(int id)
        {


            try
            {
                using (var dbContext = new EcommerceDBContext())
                {
                    var DataResponse =await dbContext.Customer.Where(c => c.CustomerId == id).Include(order => order.Orders).ThenInclude(p => p.Product).Select(customerOrder => customerOrder).ToListAsync();
                    return DataResponse;
                }

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        /// <summary>
        /// This method updating the iniformation of the customer
        /// </summary>
        /// <param name="cust"></param>
        /// <returns>boolean</returns>
        public async Task<bool> UpdateData(CustomerViewModel cust)
        {
            try
            {
                using (var dbContext = new EcommerceDBContext())
                {
                    var response = await dbContext.Customer.Include("Orders").FirstOrDefaultAsync();
                    response.Orders.FirstOrDefault().Quantity = cust._orders.Quantity;
                    response.Orders.FirstOrDefault().ProductId = cust._orders.ProductId;
                    var UpdateResponse = await dbContext.SaveChangesAsync();
                    if (UpdateResponse > 0)
                        return true;
                    else
                        return false;
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}

 