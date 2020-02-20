using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopWithCsharp
{
    class Ques4
    {
        //method overloading with different data types Parameters
        public void Person(int a)
        {
            Console.WriteLine("Person method with single int parameter : " + a);
        }
        public void Person(float salary)
        {
            Console.WriteLine("Person method with single float parameter : " + salary);
        }
        //method overloading with different parameter
        public void Person(float salary,int a)
        {
            Console.WriteLine("Person method with different data type order and doouble parameter : " + salary+"," + a);
        }
        //method overloading with different order
        public void Person(int a,float salary)
        {
            Console.WriteLine("Person with different order : " + a + "" + salary);
        }

    }
}
