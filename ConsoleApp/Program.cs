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
            // tutorial-20
            int age; 
            
            Console.Write("Enter your Age: ");
            age = Convert.ToInt32(Console.ReadLine());

            if (age >= 18) {
                isAdult();
            }

            Console.ReadLine(); // to make cmd stay on-screen
        }

        static void isAdult() 
        {
            Console.WriteLine("You are Adult");
        }
    }
}
