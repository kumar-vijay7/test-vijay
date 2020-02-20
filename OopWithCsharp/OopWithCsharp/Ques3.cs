using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopWithCsharp
{
    interface IBox
    {
         void Area(); 
    }
    interface ICircle
    {
        void Area();
    }
    class Ques3:IBox,ICircle
    {
     public void Area()
        {
            Console.WriteLine("Conflicting of Methods does not show any conflicting errors Area of Cirle is 3.14*r*r");
        }
    }
    //nothing happened in case if the inherited interfaces have conflicting method names
}
