using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //tutorial-45
            Book HPOne = new Book("Harry Potter and the Philosopher's Stone", "J.K. Rowling", 223);
            
            string HPOneFull = "First Harry Potter Book";
            Console.WriteLine($"{HPOneFull}'s Title is \"{HPOne.title}\""); 
            Console.WriteLine($"{HPOneFull}'s Author is \"{HPOne.author}\"");
            Console.WriteLine($"{HPOneFull}'s number of pages is \"{HPOne.pages}\"");
            Console.WriteLine();


            Book HPTwo = new Book(
                "Harry Potter and the Chamber of Secrets",
                "J.K. Rowling"
            )
            {
                pages = 251 // Original U.K. Edition
            };
            string HPTwoFull = "Second Harry Potter Book";
            Console.WriteLine($"{HPTwoFull}'s Title is \"{HPTwo.title}\"");
            Console.WriteLine($"{HPTwoFull}'s Author is \"{HPTwo.author}\"");
            Console.WriteLine($"{HPTwoFull}'s number of pages is \"{HPTwo.pages}\"");
            Console.WriteLine();

            Book HPThree = new Book(
                "Harry Potter and the Prisoner of Azkaban",
                "J.K. Rowling"
            );
            HPThree.pages = 317; // Original U.K. Edition
            string HPThreeFull = "Third Harry Potter Book";
            Console.WriteLine($"{HPThreeFull}'s Title is \"{HPThree.title}\"");
            Console.WriteLine($"{HPThreeFull}'s Author is \"{HPThree.author}\"");
            Console.WriteLine($"{HPThreeFull}'s number of pages is \"{HPThree.pages}\"");
            Console.WriteLine();

            Book HPFour = new Book()
            {
                title = "Harry Potter and the Goblet of Fire",
                author = "J.K. Rowling",
                pages = 636  // Original U.K. Edition
            };
            
            string HPFourFull = "Fourth Harry Potter Book";
            Console.WriteLine($"{HPFourFull}'s Title is \"{HPFour.title}\"");
            Console.WriteLine($"{HPFourFull}'s Author is \"{HPFour.author}\"");
            Console.WriteLine($"{HPFourFull}'s number of pages is \"{HPFour.pages}\"");

            Console.ReadLine(); // to make cmd stay on-screen
        }
           

    }
}
