using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCArchitecture.Models.Repository
{
    interface IEmployeeRepository
    {
        List<TBL_EMPLOYEES> EmployeeData();
        TBL_EMPLOYEES EmployeeDataById(int id);

        bool UpdateEmployeeById(TBL_EMPLOYEES id);

        bool Login(LoginModel user);
    }
}
