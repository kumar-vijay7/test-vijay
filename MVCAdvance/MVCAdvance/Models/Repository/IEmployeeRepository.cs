using MVCAdvance.Models.EntityModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCAdvance.Models.Repository
{
    public interface IEmployeeRepository
    {
        bool UserLogin(UserLogin user);
        List<TBL_EMPLOYEES> GetEmployeeData();
        bool InsertEmployee(TBL_EMPLOYEES emp);

        TBL_EMPLOYEES EmployeById(int id);
    }
}