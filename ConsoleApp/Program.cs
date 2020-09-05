using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //tutorial-30
            int guess, val = 65;
            bool guessed = false;
            while (!guessed)
            {
                Console.Write("Guess the number: ");
                guess = Convert.ToInt32(Console.ReadLine());
                if (guess < val)
                {
                    Console.WriteLine("Guess Higher");
                }
                else if (guess > val)
                {
                    Console.WriteLine("Guess Lower");
                }
                else
                {
                    guessed = true;
                    Console.WriteLine("You Guessed right the number was " + guess + " .");
                    
                }
            }
           
            Console.ReadLine(); // to make cmd stay on-screen
        }
        
    }
}
