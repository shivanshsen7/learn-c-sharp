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
            // tutorial-06
            //to create a string:
            string name = "Shivansh Sen";
            //     index=> 0123456789-10-11
            // escape chars 
            /* \" double-quotes 
             * \' single-quote
             * \n newline
             * \t tab
             * \r backspace 
             * etc.
             */
            Console.WriteLine("string name = \"Shivansh Sen\"; \n");

            // to get string length
            Console.WriteLine(name.Length + "\n");

            // to get uppercase and lower case
            Console.WriteLine(name.ToUpper());
            Console.WriteLine(name.ToLower() + "\n");

            // to check existance of sub-string
            Console.WriteLine(name.Contains("sen"));
            Console.WriteLine(name.Contains("Sen") + "\n");

            // indexing a string
            Console.WriteLine(name[0]);
            Console.WriteLine(name[3] + "\n");
            //Console.WriteLine(name[-1]); // Right-indexing not allowed.

            // get index of sub-string
            Console.WriteLine(name.IndexOf("vansh"));
            Console.WriteLine(name.IndexOf("s"));
            Console.WriteLine(name.IndexOf("d")); // get -1 if sub-string absent

            // grab sub-string via 
            // start index and no. of chars to grab
            Console.WriteLine(name.Substring(3, 5));
            Console.ReadLine(); // to make cmd stay on-screen
        }
    }
}
