using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopWithCsharp
{
    class Driver
    {
        static void Main(string[] args)
        {
            Ques1 ques1 = new Ques1();
            int choice;
            Boolean flag = false;
            while (!flag)
            {
                Console.WriteLine("---------------------------------------------------------------------------------------------------");
                Console.WriteLine("----------------------------Object Oriented Programming With C#------------------------------------");
                Console.WriteLine("---------------------------------------------------------------------------------------------------");
                Console.WriteLine("Choose One to Run Program :"
                    + "\n1)Ques1:What is the difference between abstract class and interface ? write a sample program to explain ?"
                    + "\n2)Ques2:What is method overloading and methodoverriding ? write a program ."
                    + "\n3)Ques3: What would happen in case if the inherited interfaces have conflicting method names?"
                    + "\n4)Ques4:What are the different ways a method can be overloaded ? write a program ."
                    + "\n5)Ques5:What is virtual method in c# ? Explain with program ."
                    + "\n6)Ques6:How to preventing Derived class from overriding virtual members?"
                    + "\n7)Ques7:Write a program to for parameterised constructor and call the same from derived call ?"
                    + "\n8)Ques8:Write a program to explain encapsulation and abstraction ?"
                    + "\n9)Ques9:This is extra question."
                    + "\nPress 10 For Exit");
                Console.WriteLine("---------------------------------------------------------------------------------------------------");
                Console.WriteLine("Enter Choice:");
                try { 
                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1: { ques1.ConferenceRoom();
                            break; }
                    case 2: { Ques2 ques2 = new Ques2();
                            ques2.Result();
                            ques2.Sum(2, 2);
                            ques2.Sum(10, 20, 30); };
                            break;
                    case 3: { Ques3 ques3 = new Ques3();ques3.Area(); }; 
                            break;
                    case 4: { Ques4 ques4 = new Ques4();
                            ques4.Person(10); 
                            ques4.Person(20.1f);
                            ques4.Person(10);
                            ques4.Person(10.1f,20);
                            ques4.Person(10,302.2f);};
                            break;
                    case 5: { Ques5 ques5 = new Ques5();
                            ques5.TestShow(); }; 
                            break;
                    case 6: { Ques6 ques6 = new Ques6();
                            ques6.Error(); };
                            break;
                    case 7: { Ques7 ques7 = new Ques7(); };
                            break;
                    case 8: { Ques8 ques8 = new Ques8();
                            ques8.Detail();
                              Console.WriteLine("Employee Name is : "+ques8.Empoyee);
                            };
                            break;
                    case 9: { Ques9 ques9 = new Ques9();
                               Ques9 ques9para = new Ques9("To The New");
                                TestConstructor baseconst = new Ques9();
                            };
                            break;
                    case 10:return;
                    default:
                        {
                            Console.WriteLine("Invalid Input");break;
                        }


                }
                Console.Read();
                }
                catch (Exception)
                {
                    Console.Clear();
                }
            }
        }
    }
}
