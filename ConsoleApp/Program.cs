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
            //tutorial-28
            int day = 0;
            while (day < 7)
            {
                Console.WriteLine(GetDay(day));
                ++day;  // or day++;
            }
            
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
