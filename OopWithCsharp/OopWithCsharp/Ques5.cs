using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopWithCsharp
{//virtual method are those method which is override in the derived class

    public class Test
    {
        public virtual void TestShow()
        {
            Console.WriteLine("If method is vertual it shows it is ready to override testshow method in base class");
        }
    }
    class Ques5 : Test
    {
       public override void TestShow()
        {
            Console.WriteLine("override Test Method of base class in child class");
            base.TestShow();
        }
    }
}
