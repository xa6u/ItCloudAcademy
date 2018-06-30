using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork30._06._18
{
    class Book
    {
        private string _author;
        private string _bookName;
        private int _numberOfPages;

        public Book()
        {
            _author = "unknown";
            _bookName = "unknown";
            _numberOfPages = 0;
        }

        public Book(string author, string bookName)
        {
            _author = author;
            _bookName = bookName;
        }

        public Book(string author, string bookName, int numberOfPages)
        {
            _author = author;
            _bookName = bookName;
            _numberOfPages = numberOfPages;

        }



    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
