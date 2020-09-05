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
            // tutorial-17
            string naming; 
            int age; 
          
            Console.Write("Enter a Name: ");
            naming = Console.ReadLine();
            Console.Write("Enter your age: ");
            age = Convert.ToInt32(Console.ReadLine());

            string firstRun  = SayHi(naming, age);
            string secondRun = SayHi("Shivansh Sen", 21); 
            
            Console.WriteLine(firstRun);
            Console.WriteLine(secondRun);
            Console.ReadLine(); // to make cmd stay on-screen
        }

        static string SayHi(string userName, int age) // setting string as return type
        {
            return ("Hi, "+ userName + ", " + age); // use 'return' keyword to return something

        }
    }
}
