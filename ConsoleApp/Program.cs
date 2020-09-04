using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // tutorial-08
            Console.Write("Enter your name: "); // Console.WriteLine adds "\n" at the end so w/o "\n" 
            string usrName = Console.ReadLine(); // Big Revelation => used to get a input from user.

            Console.Write("Enter your age: ");
            string usrAge = Console.ReadLine();
            Console.WriteLine("Hello " + usrName + ", great to know you are " + usrAge + " years old.");
            Console.ReadLine(); // to make cmd stay on-screen
        }
    }
}
