using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroductionToCsharp
{
    class Ques8
    {
        public void PrintTable()
        {
            
            for (int i=1; i <= 5; i++)
            {

                Console.WriteLine("------------------------");
                Console.WriteLine("Table of " + i);
                Console.WriteLine("------------------------");
                for (int j=1; j <= 10; j++)
                {
                    Console.WriteLine(+i + "x" + j + "="+i * j);
                    
                }

                Console.WriteLine("------------------------");
            }

        }
    }
}
