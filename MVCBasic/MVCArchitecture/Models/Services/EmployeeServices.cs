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
                new LoginModel(){username="Vijaykr7",password="123" },
                new LoginModel(){username="Admin",password="admin" },

            };
        }
        /// <summary>
        /// displaying Employee data
        /// </summary>
        /// <returns>list</returns>
        public List<TBL_EMPLOYEES> EmployeeData()
        {
            using (var dbcontext=new BootCamp2020Entities())
            {
                var response = dbcontext.TBL_EMPLOYEES.Select(emp => emp).ToList();
                return response;

            }
        }

        public TBL_EMPLOYEES EmployeeDataById(int id)
        {
            try
            {
                using (var dbcontext = new BootCamp2020Entities())
                {
                    var response = dbcontext.TBL_EMPLOYEES.Where(emp => emp.EMP_ID == id).FirstOrDefault();
                    return response;
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        /// <summary>
        /// Login Method
        /// </summary>
        /// <param name="user"></param>
        /// <returns>bool</returns>
        public bool Login(LoginModel user)
        {
            var uname = user.username;
            var pass = user.password;
            if(uname==user.username && pass==user.password)
            {
                return true;
            }
            else
            {
                return false;
            }
                
        }

        public bool UpdateEmployeeById(TBL_EMPLOYEES emp)
        {
            try
            {
                using (var dbcontext = new BootCamp2020Entities())
                {
                    var response = dbcontext.TBL_EMPLOYEES.Where(e => e.EMP_ID == emp.EMP_ID).FirstOrDefault();
                    emp.EMP_SALARY = dbcontext.TBL_EMPLOYEES.Single(e => e.EMP_ID == emp.EMP_ID).EMP_SALARY;
                    emp.Manager_Id = dbcontext.TBL_EMPLOYEES.Single(e => e.EMP_ID == emp.EMP_ID).Manager_Id;

                    response.EMP_ID = emp.EMP_ID;
                    response.EMP_Name = emp.EMP_Name;
                    response.EMP_SALARY = emp.EMP_SALARY;
                    response.EMP_DOB = emp.EMP_DOB;
                    response.IsTrainer = emp.IsTrainer;
                    response.Manager_Id = emp.Manager_Id;
                    var result=dbcontext.SaveChanges();
                    if (result > 0)
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