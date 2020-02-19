using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroductionToCsharp
{
    class Ques1
    {
        static string name = "Vijay Kumar";
        int emp_id=123;
        static void nameShow()
        {
            Console.WriteLine("Employee Name is: "+name);
        }
        public void idshow()
        {
            Ques1.nameShow();
            Console.WriteLine("Employee Id is : "+emp_id);
        }

    }
}
