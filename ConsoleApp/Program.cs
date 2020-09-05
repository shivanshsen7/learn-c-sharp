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
            // tutorial-13
            SayHi(); // runs only when called in main
            Console.ReadLine(); // to make cmd stay on-screen
        }

        static void SayHi()
        {
            Console.WriteLine("Hi, User");
        }
    }
}
