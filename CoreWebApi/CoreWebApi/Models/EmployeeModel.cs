using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreWebApi.Models
{
    public class EmployeeModel
    {
        public int EMP_ID { get; set; }
        public String EMP_Name { get; set; }
        public string EMP_DOB { get; set; }
        public int SALARY { get; set; }
        public int Manager_Id { get; set; }
        public bool IsTrainer { get; set; }
    }
}
