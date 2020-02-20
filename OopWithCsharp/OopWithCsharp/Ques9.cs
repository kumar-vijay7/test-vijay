using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopWithCsharp
{
    public class TestConstructor
    {
        public TestConstructor()
        {
            Console.WriteLine("I am TestConstructor(Parent) Class Default Constructor");
        }
        public TestConstructor(int a,int b)
        {
            Console.WriteLine("This is a Parent class parameterized constructor :Sum of two no "+(a+b));
        }

        static TestConstructor()
        {
            Console.WriteLine("Static constructor of base class");
        }
    }
    class Ques9: TestConstructor
    {
        public Ques9()
        {
            Console.WriteLine("Ques9 Default Constructor called");
        }
        public Ques9(string name)
        {
            Console.WriteLine("Ques9 Parameterized constructor, Parameter is : "+name);
        }
        static Ques9()
        {
            Console.WriteLine("Ques9 static constructor");
        }
    }
}
