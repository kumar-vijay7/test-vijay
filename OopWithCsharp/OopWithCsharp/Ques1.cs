using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopWithCsharp
{/* In Interface we have only abstract method only and in abstract class contain abstract as well as normal method ,
    interface decalre with the interface keyword and abstract class can be decalre with the abstract keyword,interface dont have 
    constructor but abstract contain, we cannot create the object of the abstract class
 */

    interface IEmployee
    {
        void Show();
        void Salary();
    }
    public abstract class Room
    {

        public abstract void MeetingRoom();
        public abstract void ConferenceRoom();
        static void Welcome()
        {
            Console.WriteLine("Welcome to Abstract Room Classs");
        }

    }

    class Ques1 : Room, IEmployee
    {
        //Abstract methods of Abstract Class starts here 
        public override void ConferenceRoom()
        {
            Console.WriteLine("I am ConferenceRoom defined in Drieved Class");
            MeetingRoom();
        }

        public override void MeetingRoom()
        {
            Console.WriteLine("I am MeetingRoom defined in Drieved Class");
            Salary();
        }

        //Abstract methods of Abstract Class  Ends here
        //Interface Methods Starts here
        public void Salary()
        {
            Console.WriteLine("Employee Salary from Interface");
            Show();

        }

        public void Show()
        {
            Console.WriteLine("Employee Name is Vijay Kumar From Interface");
        }
        //Interface methods Ends Here

    }
}
