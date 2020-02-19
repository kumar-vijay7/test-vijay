using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroductionToCsharp
{
    class Ques7
    {
        public void ReverseName(String namestr)
        {
            char[] charray = namestr.ToCharArray();
            int arrlength = charray.Length;
            String result = "";
            for(int i=arrlength-1;i>=0;i--)
            {
                result += charray[i].ToString();
            }
            Console.WriteLine("Reverse Name is : "+result);

        }
    }
}
