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
            //tutorial-46
            Book HPOne = new Book("Harry Potter and the Philosopher's Stone", "J.K. Rowling", 223);
                                  
            Book HPTwo = new Book(
                "Harry Potter and the Chamber of Secrets",
                "J.K. Rowling"
            )
            {
                pages = 251 // Original U.K. Edition
            };
           
            Book HPThree = new Book(
                "Harry Potter and the Prisoner of Azkaban",
                "J.K. Rowling"
            );
            HPThree.pages = 317; // Original U.K. Edition
           
            Book HPFour = new Book()
            {
                title = "Harry Potter and the Goblet of Fire",
                author = "J.K. Rowling",
                pages = 636  // Original U.K. Edition
            };
            // IsBig() return true if book has >= 500 pages.
            Console.WriteLine(HPOne.IsBig());     // false
            Console.WriteLine(HPTwo.IsBig());    // false
            Console.WriteLine(HPThree.IsBig()); // false
            Console.WriteLine(HPFour.IsBig()); // true

            Console.ReadLine(); // to make cmd stay on-screen
        }
           

    }
}
