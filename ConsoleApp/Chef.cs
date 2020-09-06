using Microsoft.Win32.SafeHandles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Chef
    {
        static protected int Salary = 5000;
        static public void Dairy()
        {
            Console.WriteLine("Dairy Products");
        }

        
    }
    class VegChef : Chef
    {
        static public new int Salary = 5500;
        static public void Veg()
        {
            Console.WriteLine("All Veg");
        }
    }
    class NonVegChef:Chef
    {

        static public new int Salary = 4500;
        static public void NonVeg()
        {
            Console.WriteLine("Non Veg");
        }
    }
}
