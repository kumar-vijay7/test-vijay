using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroductionToCsharp
{
    class Ques3
    {
        public void checkbyswitch(char ch)
        {
            char character = char.ToLower(ch);
            switch (character)
            {
                case 'a':
                    {
                        Console.WriteLine("character is a vowel");
                        break;
                    }
                case 'e':
                    {
                        Console.WriteLine("character is a vowel");
                        break;
                    }
                case 'i':
                    {
                        Console.WriteLine("character is a vowel");
                        break;
                    }
                case 'o':
                    {
                        Console.WriteLine("character is a vowel");
                        break;
                    }
                case 'u':
                    {
                        Console.WriteLine("character is a vowel");
                        break;
                    }
                default:
                    {
                        Console.WriteLine("character is a consonent");
                        break;
                    }

            }
        }
        public void checkbyifelse(char ch)
        {
            char c = char.ToLower(ch);
            if(c=='a' || c=='e'|| c=='i' || c=='o' || c=='u')
            {
                Console.WriteLine("character is a Vowels");
            }
            else
            {
                Console.WriteLine("character is consonent");
            }
        }
    }
}
