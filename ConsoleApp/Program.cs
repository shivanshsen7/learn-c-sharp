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
            // tutorial-23
          
            bool isMale = true, isTall = true;

            // DRY => Don't Repeat Yourself
            isTallMale(isMale, isTall);
            isTallMale(true, false);

            Console.ReadLine(); // to make cmd stay on-screen
        }

        static void isTallMale(bool isMale, bool isTall)
        {
            if (isMale && isTall)
            {
                Console.WriteLine("You are a tall male");
            }

            else
            {
                Console.WriteLine("You either not male or not tall, or both");
            }
        }
    }
}
