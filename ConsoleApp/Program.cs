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
            //tutorial-50
            Chef.Dairy();
            // Console.WriteLine(Chef.Salary);
            VegChef.Dairy();
            VegChef.Veg();
            Console.WriteLine(VegChef.Salary);

            NonVegChef.Dairy();
            NonVegChef.NonVeg();
            Console.WriteLine(NonVegChef.Salary);

            Console.ReadLine(); // to make cmd stay on-screen
        }
           

    }
}
