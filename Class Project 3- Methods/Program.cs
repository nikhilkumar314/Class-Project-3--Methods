using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Project_3__Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Username(); //Calls the method we made below 
        }

        static void Username ()
        {
            //try catch to catch errors
            try
            {
                //Asks user to enter their name
                Console.Write("Please enter your name: ");
                string input = Console.ReadLine(); //Reads what the user entered plus stores it as a string value called input
                Console.WriteLine("Hello" + " " + input + "!"); //Displays information
            }
            catch //catch starts
            {
                Console.WriteLine("Please enter your name!");
            }
     
        }
    }
}
