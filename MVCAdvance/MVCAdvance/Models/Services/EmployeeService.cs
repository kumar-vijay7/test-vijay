using MVCAdvance.Models.EntityModel;
using MVCAdvance.Models.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCAdvance.Models.Services
{
    public class EmployeeService : IEmployeeRepository
    {
        public TBL_EMPLOYEES EmployeById(int id)
        {
            using (var dbcontext = new conn())
            {
                var response = dbcontext.TBL_EMPLOYEES.Where(e=>e.EMP_ID==id).FirstOrDefault();
                return response;
            }

        }

        /// <summary>
        /// Getting Employee Data
        /// </summary>
        /// <returns></returns>
        public List<TBL_EMPLOYEES> GetEmployeeData()
        {
            using (var dbcontext=new conn())
            {
                var response = dbcontext.TBL_EMPLOYEES.Select(emp => emp).ToList();
                return response;
            }

        }

        public bool InsertEmployee(TBL_EMPLOYEES emp)
        {
            using (var dbcontext = new conn())
            {
                dbcontext.TBL_EMPLOYEES.Add(emp);
                var response = dbcontext.SaveChanges();
                if (response > 0)
                    return true;
                else
                    return false;
            }
        }

        /// <summary>
        /// Login User 
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public bool UserLogin(UserLogin user)
        {
           
            using (var dbcontext=new conn())
            {
                var response = dbcontext.UserLogins.FirstOrDefault();
                if(response.Username==user.Username && response.Password == user.Password)
                {
                    return true;
                }
                else
                {
                    return false;
                }
                


            }
        }
    }
}