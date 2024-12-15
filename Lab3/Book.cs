using Lab3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    internal class Book
    {
        public string title;
        public Person author;
        public string data;

        public Book(string title, Person author, string data)
        {
            this.title = title;
            this.author = author;
            this.data = data;
        }

        public void View()
        {
            Console.WriteLine($"Tytul: {title}");
            Console.WriteLine($"Autor: ");
            author.View();
            Console.WriteLine($"Data: {data}");

        }
        
    }
}

