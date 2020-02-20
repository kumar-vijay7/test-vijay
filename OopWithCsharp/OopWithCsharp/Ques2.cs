using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopWithCsharp
{/*method overloading is a concept when a same method name with different parameters, orders and datatypes*/
    public class Overloading
    {
        public void Sum(int x,int y)
        {
            Console.WriteLine("Sum of two number is :"+(x + y));
        }
        public void Sum(int x, int y,int z)
        {
            Console.WriteLine("Sum of three number is :" +(x + y+z));
        }
        public virtual void Result()
        {
            Console.WriteLine("Hello from base class result method");
        }
    }
    class Ques2 : Overloading
    {
            /* overriding is a concept where base class have the method with the virtual keyword it means it is ready to override
             in child class overriide keyword is prefix with the override method 
             */

        public override void Result()
        {
            Console.WriteLine("Hellow from Child class override result method of base class");
            base.Result();
        }
    }
    
}
