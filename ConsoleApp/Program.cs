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
            // tutorial-14
            string naming;
            Console.Write("Enter a Name: ");
            naming = Console.ReadLine();
            SayHi(naming);
            SayHi("Shivansh Sen"); // can directly call and also multiple times
            Console.ReadLine(); // to make cmd stay on-screen
        }

        static void SayHi(string userName)
        {
            Console.WriteLine("Hi, "+ userName);
        }
    }
}
