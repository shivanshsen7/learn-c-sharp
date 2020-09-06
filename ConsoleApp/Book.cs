using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Book
    {
        public string author;
        public string title;
        private int pages;
        public Book( string title_, string author_, int pages_)
        {
            Console.WriteLine("New Book Created");
            author = author_;
            title = title_;
            pages = pages_;

        }
        public Book(string title_,string author_)
        {
            Console.WriteLine("New Book Created");
            author = author_;
            title = title_;
        }
        public Book(int pages_)
        {
            Console.WriteLine("New Book Created");
            pages = pages_;
        }
        public Book()
        {
            Console.WriteLine("New Book Created");
        }

        public bool IsBig()
        {
            if (pages >= 500)
                return true;
            return false;
        }

    }
}
