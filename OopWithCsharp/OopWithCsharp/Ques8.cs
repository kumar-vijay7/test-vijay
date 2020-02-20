using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopWithCsharp
{
    public abstract class MyAbstract
    {
        //this is the abstract class which contain the abstract method
        public abstract void Detail();
    }
    class Ques8:MyAbstract
    {
        //Example of Encapsulation class with Private member Field 
        private string _ename="Vijay Kumar";
        
        public override void Detail()// abstract class method definition defined here 
        {
            Console.WriteLine("Abstract Method Definition Here");
        }
        public String Empoyee // this is the property  which provide only the read-only permission to user
        {
            get
            {
                return _ename;
            }
        }
    }
}
