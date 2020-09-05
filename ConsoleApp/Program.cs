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
            // tutorial-25
          
            bool isMale = true, isTall = true;

            isTallOrMale(isMale, isTall); // isMale && isTall
            isTallOrMale(true, false); // isMale && !isTall
            isTallOrMale(false, false); // !isMale && isTall
            isTallOrMale(false, true); // !isMale && !isTall => else
            Console.ReadLine(); // to make cmd stay on-screen
        }

        static void isTallOrMale(bool isMale, bool isTall)
        {
            if (isMale && isTall)
            {
                Console.WriteLine("You are a tall male.");
            }

            else if (isMale && !isTall)
            {
                Console.WriteLine("You a short male.");
            }
            else if (!isMale && isTall)
            {
                Console.WriteLine("You Tall but not male.");
            
            }
            else
            {
                Console.WriteLine("You are short and not male.");
            }
        
        }
    }
}
