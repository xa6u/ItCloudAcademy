using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_30._06._18
{
    class Book
    {
        private string _author;
        private string _title;
        private int _pageNumber;

        public Book()
        {
            _author = "unknown";
            _title = "unknown";
            _pageNumber = 0;

        }

        public Book(string author, string title)
        {
            _author = author;
            _title = title;
        }

        public Book(string author, string title, int pageNumber)
        {
            _author = author;
            _title = title;
            _pageNumber = pageNumber;
        }

        public string Author
        {
            get
            {
                return _author;
            }
        }
        public string Title
        {
            get
            {
                return _title;
            }
        }
        public int PageNumber
        {
            get
            {
                return _pageNumber;
            }
        }

        public virtual void Print()
        {
            Console.WriteLine($"Book info: Author {Author}, Title {Title}, number of pages {PageNumber}");
        }
    }
    class TecnicalBook :Book
    {
        private string _scienceBranch;

        public string ScienceBranch
        {
            get
            {
                return _scienceBranch;
            }
        }


        public override void Print()
        {
            Console.WriteLine($"Book info: Author {Author}, Title {Title}, number of pages {PageNumber}, Science branch {ScienceBranch}");
        }
    }
    class Fiction :Book
    {

    }



    class Program
    {
        static void Main(string[] args)
        {


        }
    }
}
