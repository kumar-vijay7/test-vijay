using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCArchitecture.Models.Repository
{
    interface IEmployeeRepository
    {
        bool InsertEmployee(TBL_EMPLOYEES emp);
        string UserLogin(LoginModel userinfo);
        List<TBL_EMPLOYEES> EmployeeData();
    }
}
