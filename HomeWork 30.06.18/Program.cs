using HomeWork_30._06._18;
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

        public TecnicalBook(string author, string title, int pageNumber,string scienceBranch):
            base(author,title,pageNumber)
        {
            _scienceBranch = scienceBranch;
        }

        public override void Print()
        {
            //Console.WriteLine($"Book info: Author {Author}, Title {Title}, number of pages {PageNumber}, Science branch {ScienceBranch}");
            Console.Write($"Science branch: {ScienceBranch}, ");
            base.Print();
            
        }
    }
    class Fiction :Book
    {
        public Fiction(string author, string title, int pageNumber) :
            base(author, title, pageNumber)
        {

        }

    }

    public enum BookType
    {
        All,
        Tech,
        Fiction
    }

    class Library
    {

        private List<Book> _books;

        public void Add(Book book)
        {
            _books.Add(book);
        }

        public void Print(BookType bookType)
        {
            switch (bookType)
            {
                case BookType.All:
                    break;
                case BookType.Tech:
                    break;
                case BookType.Fiction:
                    break;
                default:
                    break;
            }
        }

        public Library()
        {
            _books = new List<Book>;
        }

           
        }
    }



    class Program
    {
        static void Main(string[] args)
        {
        //var books = new List<Book>();
        //books.Add(new Book("Lion Tolstoy", "Voskresenie", 345));
        //books.Add(new TecnicalBook ("Jefrey Richter", "C# Core", 344, ".Net" ));

        //foreach (var item in books)
        //{
        //    item.Print();
        //}



        }
    }
}
