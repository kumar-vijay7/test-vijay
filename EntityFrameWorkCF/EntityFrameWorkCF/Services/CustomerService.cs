using EntityFrameWorkCF.Models;
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
        public async Task<bool> DeleteData(Orders order)
        {
            try
            {
                using (var dbContext = new EcommerceCodeFirstDbContext())
                {
                    var response = dbContext.Customers.First(customer => customer.CustomerId == order.CustomerId);
                    dbContext.Customers.Remove(response);
                    var response2= dbContext.Orders.First(order => order.OrderId == order.OrderId);
                    dbContext.Orders.Remove(response2);
                    var response3 = dbContext.Products.First(product => product.ProductId == order.ProductId);
                    dbContext.Products.Remove(response3);
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
                using (var dbContext = new EcommerceCodeFirstDbContext())
                {
                    var DataResponse =await dbContext.Customers.Include("Orders").Select(customerOrder => customerOrder).ToListAsync();
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
                using (var dbContext = new EcommerceCodeFirstDbContext())
                {
                    dbContext.Customers.Add(cust._customer);
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
                using (var dbContext = new EcommerceCodeFirstDbContext())
                {
                    var DataResponse =await dbContext.Customers.Where(c => c.CustomerId == id).Include(order => order.Orders).ThenInclude(p => p.Product).Select(customerOrder => customerOrder).ToListAsync();
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
                using (var dbContext = new EcommerceCodeFirstDbContext())
                {
                    dbContext.Orders.Add(cust._orders);
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

 