using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopWithCsharp
{
    public class Myclass
    {
       public virtual void MyMethod()
        {
            Console.WriteLine("base method");
        }
    }
    public class Myclass2 : Myclass
    {
        public sealed override void MyMethod()
        {
            Console.WriteLine("Sealed method called by the base keyword");
            base.MyMethod();
        }
    }
    class Ques6 : Myclass2
    {
        public void Error()
        {
            Console.WriteLine("We cannot override sealed method in the derived class");
            base.MyMethod();
        }
        //WE cannot override the sealed method in the derived class
       /*
        public override void MyMethod()
        {
            Console.WriteLine();
        }*/
    }
}
    
 
