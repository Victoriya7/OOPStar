using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork4
{
    class Title
    {
        public string TitleName { get;  set; }
        public string Show()
        {
            return "Title Name: " + TitleName;
        }
    }

    class Autor
    {
        public string AutorName { get; set; }
        public string Show()
        {
            return "Autor Name: " + AutorName;
        }
    }
     
    class Content
    {
        public string ContentName { get; set; }
        public string Show()
        {
            return "Content Name: " + ContentName;
        }
    }
    class Book
    {
        Title _title = new Title();
        Autor _autor = new Autor();
        Content _content = new Content();

        public Book(string title, string autor, string content)
        {
            _title.TitleName = title;
            _autor.AutorName = autor;
            _content.ContentName = content;
        }
        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(_title.Show() + "\n" + _autor.Show() + "\n" + _content.Show());
            Console.ResetColor();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            string title = "", autor = "", content = "";

            Console.WriteLine("Please type Title, Autor name and Content");
            title = Console.ReadLine();
            autor = Console.ReadLine();
            content = Console.ReadLine();

            Book book = new Book(title, autor, content);
            book.Show();

            Console.ReadKey();
        }
    }
}
 