using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork
{
    class Book
    {
        protected string _title;
        protected string _autor;
        protected string _content;
        public string BookName { get { return _title + " " + _autor + " " + _content; } }
        public Book(string title, string autor, string content)
        {
            _title = title;
            _autor = autor;
            _content = content;
        }
        /*protected Book()
        { }*/
    }
    class Title //: Book
    {
        string _titlename;
        public string SetTitle { set { _titlename = value; } get { return _titlename; } }
        public void Show()
        {
            Console.BackgroundColor = ConsoleColor.Cyan;
            Console.WriteLine(SetTitle);
            Console.ResetColor();
        }
    }

    class Autor //: Book
    {
        string _autor;
        public string SetAutor { set; get; }

        public void Show()
        {
            Console.BackgroundColor = ConsoleColor.Green;
            Console.WriteLine(SetAutor);
            Console.ResetColor();
        }
    }

    class Content //: Book
    {
        string _content; public string SetContent { set; get; }

        public void Show()
        {
            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine( SetContent);
            Console.ResetColor();
        }
    }

    class Program
    {
        static void Main()
        {
            string st1 = "", st2 = "", st3 = "";
            Console.WriteLine("Write title of book, autor, content");
            st1 = Console.ReadLine();
            st2 = Console.ReadLine();
            st3 = Console.ReadLine();

            Title instance1 = new Title();
            instance1.SetTitle = st1;
            instance1.Show();

            Autor instance2 = new Autor();
            instance2.SetAutor = st2;
            instance2.Show();

            Content instance3 = new Content();
            instance3.SetContent = st3;
            instance3.Show();

            Book instansemain = new Book(instance1.SetTitle, instance2.SetAutor, instance3.SetContent);
            Console.WriteLine(instansemain.BookName);

            Console.ReadKey();
        }
    }
}
