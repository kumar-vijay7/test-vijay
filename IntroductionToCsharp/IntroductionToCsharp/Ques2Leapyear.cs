using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroductionToCsharp
{
    class Ques2Leapyear
    {
        public void LeapYearCheck(int year)
        {
            if (year % 400 == 0)
            {
                Console.WriteLine("Year is a Leap Year", +year);
            }
            else if (year % 100 == 0)
            {
                Console.WriteLine("Year is not a Leap Year", +year);
            }
            else if (year % 4 == 0)
            {
                Console.WriteLine("Year is a Leap Year", +year);
            }
            else
            {
                Console.WriteLine("Year is not a Leap year", +year);
            }

            Console.Read();
        }
        
    }
}
