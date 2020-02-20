using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopWithCsharp
{
    public class Parent
    {
       //this is the parent class constructor 
       public Parent(String message)
        {
            Console.WriteLine("Base Class Constructor Message : " +message);
        }
       
    }

   public  class Ques7 : Parent
    {

        //this part calling the base class parameterized constructor
        public Ques7():base("Welcome in To The New")
        {

        }
    }
}
