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
            //tutorial-27
            Console.WriteLine(GetDay(0));
            Console.ReadLine(); // to make cmd stay on-screen
        }
        static string GetDay(int dayNum)
        {
            string dayName;

            switch (dayNum)
            {
                case 0:
                    dayName = "Monday";
                    break;
                case 1:
                    dayName = "Tuesday";
                    break;
                case 2:
                    dayName = "Wednesday";
                    break;
                case 3:
                    dayName = "Thrusday";
                    break;
                case 4:
                    dayName = "Friday";
                    break;
                case 5:
                    dayName = "Saturday";
                    break;
                case 6:
                    dayName = "Sunday";
                    break;
                default:
                    dayName = "Invalid Day";
                    break;
            }

            return dayName;
        } 
    }
}
