using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroductionToCsharp
{
    class Ques6
    {
        private int Emp_id = 100;
        protected String name = "vijay";
        public String company = "ToTheNew";
        internal int mobile = 123456;
        protected internal String address = "Akshardham";
        public void BaseShow()
        {
            Console.WriteLine("(Private Employee id : " + Emp_id);
            Console.WriteLine("Address is a protected internal in base class :" + address);
        }
    }
    class Drived : Ques6
    {
        Ques6 obj = new Ques6();
        public void DrivedShow()
        {
            Console.WriteLine("Name is a Protected Member : " +name);
            Console.WriteLine("Company is a public member : " + company);
            Console.WriteLine("Mobile is a Internal member : " + mobile);
            Console.WriteLine("Address is a protected internal in drived class : " + address);
        }

        /*Protected Internal provide the accessibility in the same class as well as in the drived class of other assembily*/
    }
}
