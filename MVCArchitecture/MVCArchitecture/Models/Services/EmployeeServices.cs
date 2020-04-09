using MVCArchitecture.Models.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCArchitecture.Models.Services
{
    public class EmployeeServices : IEmployeeRepository
    {
        List<LoginModel> user = null;
        public EmployeeServices()
        {
            user = new List<LoginModel>()
            {
                new LoginModel{username="Vijaykr",password="vijay123"}
            };
            
                
        }
        /// <summary>
        /// Getting Employee Data
        /// </summary>
        /// <returns>List Employee table</returns>
        public List<TBL_EMPLOYEES> EmployeeData()
        {
            try
            {
                using (BootCamp2020Entities dbcontext = new BootCamp2020Entities())
                {
                    return dbcontext.TBL_EMPLOYEES.Select(emp => emp).ToList();
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
                
        }
        /// <summary>
        /// Inserting Employee Data into Database
        /// </summary>
        /// <param name="emp"></param>
        /// <returns></returns>
        public bool InsertEmployee(TBL_EMPLOYEES emp)
        {
            try
            {
                using (BootCamp2020Entities dbcontext = new BootCamp2020Entities())
                {
                    dbcontext.TBL_EMPLOYEES.Add(emp);
                    var response = dbcontext.SaveChanges();
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
        /// Performing Login from the list data source
        /// </summary>
        /// <param name="userinfo"></param>
        /// <returns>string</returns>
        public string UserLogin(LoginModel userinfo)
        {
            try
            {
                var result = user;
                if (user.FirstOrDefault().username == userinfo.username && user.FirstOrDefault().password == userinfo.password)
                {
                    return result.FirstOrDefault().username;
                }
                else
                {
                    return "value not found";
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}