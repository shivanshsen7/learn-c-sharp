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
            // tutorial-05
            string phrase = "Shivansh Sen";
            Console.WriteLine("string Multi-char in double quotes.");
            Console.WriteLine("Phrase => " + phrase);
            char grade = 'A'; // char grader = "A"; invalid to use double-quotes
            Console.WriteLine("char single-char in single quotes.");
            Console.WriteLine("grade => " + grade);

            int age = 19;
            Console.WriteLine("int is a intger type w/o any quotes.");
            Console.WriteLine("age => " + age);

            float leastAccurate = 30.0f;
            Console.WriteLine("float is least accurate real number, need suffix 'f'.");
            Console.WriteLine("leastAccurate => " + leastAccurate);

            double midAccurate = 4154.54584154;
            Console.WriteLine("double is at a sweet spot can be used in most cases, no need for any suffix.");
            Console.WriteLine("midAccurate => " + midAccurate);

            decimal mostAccurate = 8484848.8484848484m;
            Console.WriteLine("Decimal is most reliable and accurate but slow, need suffix 'm'.");
            Console.WriteLine("mostAccurate => " + mostAccurate);

            bool isAdult = true; // true or false
            Console.WriteLine("bool is use dfor only true (1) and false (0) values.");
            Console.WriteLine("isAdult => " + isAdult);
            Console.ReadLine(); // to make cmd stay on-screen
        }
    }
}
