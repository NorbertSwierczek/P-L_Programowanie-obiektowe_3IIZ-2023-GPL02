using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Student
    {
        public string firstName;
        public string lastName;
        public double[] tab = new double[5];
        int count = 0;

        public double SredniaOcen
        {
            get
            {
                double sum = 0;
                for (int i = 0; i < count; i++)
                {
                    sum += tab[i];
                }
                return sum / count;
                ;
            }
            set
            {
                SredniaOcen = value;
                ;
            }
        }
        public void DodajOcene(int ocena)
        {
            if (ocena > 0 && ocena < 6)
            {
                tab[count] = ocena;
                count++;
            }
            else
            {
                Console.WriteLine("Ocena musi byc z zakresu 1-5");
            }
            Console.WriteLine($"Dodano: {ocena}\tŚrednia ocen: {SredniaOcen}");
        }

        public Student(string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
        }

        public void View()
        {
            Console.WriteLine($"Imię:{firstName}, Nazwisko: {lastName}");
        }
    }
}

