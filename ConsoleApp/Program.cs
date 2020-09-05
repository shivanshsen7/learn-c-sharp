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
            // tutorial-24
          
            bool isMale = true, isTall = true;

            // DRY => Don't Repeat Yourself
            isTallOrMale(isMale, isTall);
            isTallOrMale(true, false);

            Console.ReadLine(); // to make cmd stay on-screen
        }

        static void isTallOrMale(bool isMale, bool isTall)
        {
            if (isMale || isTall)
            {
                Console.WriteLine("You are either tall or male, or both.");
            }

            else
            {
                Console.WriteLine("You either neither male or nor tall.");
            }
        }
    }
}
