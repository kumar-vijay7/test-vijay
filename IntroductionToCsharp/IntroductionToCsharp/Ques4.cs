using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroductionToCsharp
{
    class Ques4
    {
        public void boxing()
        {
            int emp_id = 123456;
            Object boxobj = emp_id;
            Console.WriteLine("Boxing is converting value type to reference type"+boxobj);
        }
        public void unboxing()
        {
            int phone = 2132546;
            Object boxobj2 = phone;
            int unboxing = (int)boxobj2;
            Console.WriteLine("unboxing :" + unboxing);

        }
    }
}
