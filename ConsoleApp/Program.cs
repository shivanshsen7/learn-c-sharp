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
            // tutorial-16
            string naming; // can name differently 
            int age; // But also same.
            // You'll get into it in scopes
            Console.Write("Enter a Name: ");
            naming = Console.ReadLine();
            Console.Write("Enter your age: ");
            age = Convert.ToInt32(Console.ReadLine());

            SayHi(naming, age);
            SayHi("Shivansh Sen", 21); // can directly call and also multiple times
            // SayHi("Shivansh Sen"); // Error not enought params

            Console.ReadLine(); // to make cmd stay on-screen
        }

        static void SayHi(string userName, int age)
        {
            Console.WriteLine("Hi, "+ userName + ", " + age);

        }
    }
}
