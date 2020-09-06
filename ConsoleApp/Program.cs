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
            //tutorial-48
            Book HPOne = new Book(
                title_:"Harry Potter and the Philosopher's Stone", 
                author_:"J.K. Rowling",
                pages_:223); // Named Arguments

            Book HPTwo = new Book(
                "Harry Potter and the Chamber of Secrets",
                "J.K. Rowling",
                251
            ); // Positional Arguments
            
           
            Book HPThree = new Book(
                "Harry Potter and the Prisoner of Azkaban",
                "J.K. Rowling"
                
            );

            // HPThree.Pages = 100001;
            // HPThree.Pages = 0;
            HPThree.Pages = 317;

            Book HPFour = new Book(pages_:636)
            {
                title = "Harry Potter and the Goblet of Fire",
                author = "J.K. Rowling"
                
            };
            

            Console.ReadLine(); // to make cmd stay on-screen
        }
           

    }
}
