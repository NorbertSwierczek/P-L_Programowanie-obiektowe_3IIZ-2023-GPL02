using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Reflection.Metadata.BlobBuilder;

namespace Lab3
{
    internal class Reader : Person
    {
        protected List<Book> ksiazki = new List<Book>();
        

        public Reader(string firstName, string lastName, int age, List<Book> ksiazki) : base(firstName, lastName, age)
        {
            this.ksiazki = ksiazki;
        }

        public void ViewBook()
        {
            foreach (Book element in ksiazki)
            {
                element.View();
            }
        }
        public override void View()
        {
            base.View();
            ViewBook();
        }
    }
}


