using CoreWebApi.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace CoreWebApi.Data
{
   public interface IEmployeeOperations
    {
        public DataSet GetEmployee();
        public DataSet GetEmp(EmployeeModel employee);
        public bool PostInsert(EmployeeModel employee);
        public bool PutEmp(EmployeeModel employee);
        public bool DeleteEmp(EmployeeModel employee);
    }
}
