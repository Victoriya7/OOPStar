using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkClasses2
{
    class Book
    {
        protected string _title;
        protected string _autor;
        protected string _content;
        public Book(string title, string autor, string content)
        {
            _title = title;
            _autor = autor;
            _content = content;
        }
        protected Book()
        { }
    }
    class Title : Book
    { 
        string _titlename; 
        private string SetTitle { set; get; }
        protected Title(string title, string autor, string content) : base(title, autor, content)
        {
            _titlename = title;
        }
        public Title()
        { }
        public void Show()
        {
            Console.WriteLine(_titlename);
        }
    }
    class Autor : Book
    { 
        string _autor; 
        private string SetAutor { set; get; }
        protected Autor(string title, string autor, string content) : base(title, autor, content)
        {
            _autor = autor;
        }
        public Autor()
        { }
        public void Show()
        {
            Console.WriteLine(_autor);
        }
    }

    class Content : Book
    { 
        string _content; public string SetContent { set; get; }
        protected Content(string title, string autor, string content) : base(title, autor, content)
        {
            _content = content;
        }
        public Content()
        { }
        public void Show()
        {
            Console.WriteLine(_content);
        }
    }

    class Program
    {
        static void Main()
        {
            string st1 = "", st2 = "", st3 = "";
            Console.WriteLine(st1);
            Console.WriteLine(st2);
            Console.WriteLine(st3);
            Book instnce1 = new Book(st1, st2, st3);

            Title instance2 = new Title();
            instance2.Show();
        }
    }
}
