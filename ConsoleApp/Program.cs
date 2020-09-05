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
            // tutorial-21
            int age;
            bool isMale;
            Console.Write("Enter your Age: ");
            age = Convert.ToInt32(Console.ReadLine());

            if (age >= 18) {
                isAdult();
            }
            Console.Write("If male enter 'y': ");
            if ("y" == Console.ReadLine()) {
                Console.WriteLine("You are male");
            }
            //Console.Write("If male enter 'y': ");
            //isMale = "y" == Console.ReadLine();
            //if (isMale)
            //{
            //    Console.WriteLine("You are male");
            //}
            else
            {
                Console.WriteLine("You are not male");
            }

            Console.ReadLine(); // to make cmd stay on-screen
        }

        static void isAdult() 
        {
            Console.WriteLine("You are Adult");
        }
    }
}
