using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Reflection.Metadata.BlobBuilder;

namespace Lab3
{
    internal class Reviewer : Reader
    {
        public Reviewer(string firstName, string lastName, int age, List<Book> ksiazki) : base(firstName, lastName, age, ksiazki)
        {
        }
        public override void View()
        {
            foreach (var item in ksiazki)
            {
                item.View();
                Console.WriteLine($"Ocena: {new Random().Next(1, 11)}");
            }
        }
    }
}
