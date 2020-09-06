using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Book
    {
        static private int count = 0;
        public string author;
        public string title;
        private int pages;
        public Book( string title_, string author_, int pages_)
        {
            Console.WriteLine("New Book Created");
            author = author_;
            title = title_;
            pages = pages_;

            count++;

        }
        public Book(string title_,string author_)
        {
            Console.WriteLine("New Book Created");
            author = author_;
            title = title_;
            count++;
        }
        public Book(int pages_)
        {
            Console.WriteLine("New Book Created");
            pages = pages_;

            count++;
        }
        public Book()
        {
            Console.WriteLine("New Book Created");

            count++;
        }

        public bool IsBig()
        {
            if (pages >= 500)
                return true;
            return false;
        }
        public int Pages
        {
            get { return pages; }
            set { if (value.GetType() == typeof(int) && value <= 10E4 && value > 0)
                {
                    pages = value;
                }
                else
                {
                    Console.WriteLine($"No. of pages in a book can't be {value}");
                }
            }
        }
        static public int Count
        {
            get { return count; }
        }
    }
}
