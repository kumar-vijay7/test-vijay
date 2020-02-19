using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroductionToCsharp
{
    class Driver
    {
        static void Main(string[] args)
        {
         //Object Creation Starts from Here   
            Ques1 ques1 = new Ques1();
            Ques2Leapyear ques2 = new Ques2Leapyear();
            Ques3 ques3 = new Ques3();
            Ques4 ques4 = new Ques4();
            Drived ques6 = new Drived();
            Ques7 ques7 = new Ques7();
            Ques8 ques8 = new Ques8();
        //Object Creation Ends here
            int choice;
            Boolean flag = false;
        //While Loop start from here to Execute the driven menu multiple times
            while (!flag)
            {
                Console.WriteLine("--------------------------------------------------------------------------");
                Console.WriteLine("             Welcome to the Introduction to the CSharp");
                Console.WriteLine("--------------------------------------------------------------------------");
                Console.WriteLine("please select the program you want to run: \n1)static instance members " +
                    "\n2)Leap Year" +
                    " \n3Vowel and Consonant check" +
                    "\n4)boxing and unboxing" + "\n5)Reverse Name"+"\n6)Print Table 1 to 5"+"\n7)Access Modifiers"+"\n8)Exit");
                Console.WriteLine("--------------------------------------------------------------------------");
                try { 
                choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1://Ques1 Write a program to show the difference between Static & Instance Member?
                        {
                            Console.WriteLine("Press 1 To call the non static method");
                            choice = Convert.ToInt32(Console.ReadLine());
                            if (choice == 1)
                            {
                                ques1.idshow();
                            }
                            else
                            {
                                Console.WriteLine("invlaid input");
                            }
                            break;

                        }
                    case 2://Ques2:Write a program to find the leap year?
                        {
                            int year;
                            Console.WriteLine("Enter the year to check the leap year");
                            year = Convert.ToInt32(Console.ReadLine());
                            ques2.LeapYearCheck(year);
                            break;

                        }
                    case 3://Ques3:Write a program To find Constant & vowel using both Switch case & if_else?
                        {
                            char c;
                            Console.WriteLine("Enter the Character to check wheater is a Vowel or Consonent");
                            c = Convert.ToChar(Console.ReadLine());
                            Console.WriteLine("Select 1)CheckBySwitch 2)checkByIfElse");
                            choice = Convert.ToInt32(Console.ReadLine());
                            if (choice == 1)
                            {
                                ques3.checkbyswitch(c);
                            }
                            else if (choice == 2)
                            {
                                ques3.checkbyifelse(c);
                            }
                            else
                            {
                                Console.WriteLine("invlaid input");
                            }
                            break;

                        }
                    case 4://Write a program to define the boxing and unboxing concepts?
                        {
                            Console.WriteLine("Select 1)Boxing 2)Unboxing");
                            choice = Convert.ToInt32(Console.ReadLine());
                            if (choice == 1)
                            {
                                ques4.boxing();
                            }
                            else if (choice == 2)
                            {
                                ques4.unboxing();
                            }
                            else
                            {
                                Console.WriteLine("invalid");
                            }
                            break;
                        }
                    case 5://Ques:7Write a program to reverse your full name without using an inbuilt function?(P)
                        {
                            String name = "";
                            Console.WriteLine("Enter the name for reverse\n");
                            name = Console.ReadLine();
                            Console.WriteLine("Entered Name is : " + name);
                            ques7.ReverseName(name);
                            break;

                        }
                    case 6://Ques6:Write a program to define the scope of different access modifiers?(P)
                             ques8.PrintTable();break;
                    case 7://Ques7:Write a program to reverse your full name without using an inbuilt function?(P)
                            ques6.DrivedShow();
                            break;
                    case 8:return;
                    default:
                        {
                            Console.WriteLine("Invalid input");
                            break;
                        }

                }
                }
                catch (Exception)
                {
                    Console.WriteLine("Please Enter the Integer Value");
                    

                }


                Console.Read();

            }
        }
    }
}
