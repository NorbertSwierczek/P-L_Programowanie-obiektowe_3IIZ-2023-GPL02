using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Osoba
    {
        public string firstName;
        public string secondName;
        public int age;

        public string FirstName{
            get { return firstName; }
            set
            {
                if (value.Length > 2) firstName = value;
                else Console.WriteLine("Imię musi mieć conajmniej dwa znaki!");
            }
        }

        public string SecondName
        {
            get { return secondName; }
            set
            {
                if (value.Length > 2) secondName = value;
                else Console.WriteLine("Nazwisko musi mieć conajmniej dwa znaki!");
            }
        }

        public int Age
        {
            get { return age; }
            set
            {
                if(value>0) age = value;
                else Console.WriteLine("Wiek musi być dodatni!");
            }
        }

        public Osoba(string firstName, string secondName, int age)
        {
            this.firstName = firstName;
            this.secondName = secondName;
            this.age = age;
        }

        public void WyswietlInformacje()
        {
            Console.WriteLine($"Imie:{firstName}" + $"Nazwisko: {secondName}" + $"Wiek: {age}");
        }
    }
}
