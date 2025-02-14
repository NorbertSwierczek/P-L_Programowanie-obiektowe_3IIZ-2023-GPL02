using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;


namespace Lab6
{
    class Program
    {

        static void ReadFiles()
        {
            var document1 = File.ReadAllText(@"C:\textfiles\read\document1.txt");
            var document2 = File.ReadAllLines(@"C:\textfiles\read\document2.txt");

            var document2string = string.Join("\n", document2);

            Console.WriteLine(document1 + " \n Kolejne gowno \n" + document2string);
        }

        static void GenerateDocuments()
        {
            Console.WriteLine("Podaj imie");
            var name = Console.ReadLine();

            Console.WriteLine("Podaj numer zamowienia");
            var orderNumber = Console.ReadLine();

            var template = File.ReadAllText(@"C:\textfiles\write\template.txt");
            var document = template.Replace("{name}", name)
                .Replace("{orderNumber", orderNumber)
                .Replace("{dateTime}", DateTime.Now.ToString());

            File.WriteAllText($@"C:\textfiles\write\document-{name}.txt", document);
        }

        static void GenerujPlik() //zad1
        {
            Console.WriteLine("Podaj nazwę pliku: ");
            var filename = Console.ReadLine();

            Console.WriteLine("Podaj nr. albumu: ");
            var album = Console.ReadLine();

            File.WriteAllText($@"C:\textfiles\write\{filename}.txt", album);
        }

        static void zadanie2()
        {
            Console.WriteLine("Podaj nazwę pliku: ");
            var nazwa = Console.ReadLine();

            var dokument = File.ReadAllText(@$"C:\textfiles\write\{nazwa}.txt");

            Console.WriteLine(dokument);
        }

        static void Zadanie3()
        {

            string[] pesele = File.ReadAllLines(@"C:\textfiles\write\pesel.txt");
            int licznik = 0;
            foreach (var item in pesele)
            {
                if (item[9] % 2 == 1) // 9. cyfra PESEL-u decyduje o płci
                {
                    licznik++;
                }
            }

            Console.WriteLine(licznik);
        }
             class PopulationData
            {
                public Indicator indicator {  get; set; }
                public Country country { get; set; }
                public string Country { get; internal set; }
                public string value { get; set; }
                public int Value { get; internal set; }
                public string date { get; set; }
                public int Year { get; internal set; }
        }
             class Country { 
                public string Id { get; set; }
                public int Value { get; set; }
            }
             class Indicator {
                public string Id { get; set; }
                public int Value { get; set; }
            }       

        static void ShowPopulationDifference(List<PopulationData> data, string country, int year1, int year2)
        {
            var pop1 = data.FirstOrDefault(d => d.Country == country && d.Year == year1)?.Value;
            var pop2 = data.FirstOrDefault(d => d.Country == country && d.Year == year2)?.Value;

            Console.WriteLine(pop2 - pop1);
        }

        interface IPersonRepository
        {
            void SavePerson(Person person);
            List<Person> LoadPeople();
        }

        class Person
        {
            public string Name { get; set; }
            public int Age { get; set; }
            public string Email { get; set; }
        }

        class FilePersonRepository : IPersonRepository
        {
            public string filePath = "zadanie4_1.json";

            public List<Person> LoadPeople()
            {
               
                return JsonSerializer.Deserialize<List<Person>>(File.ReadAllText("zadanie4_1.json")) ?? new List<Person>();
            }

            public void SavePerson(Person person)
            {
                List<Person> people = LoadPeople();
                people.Add(person);
                string jsonString = JsonSerializer.Serialize(people, new JsonSerializerOptions { WriteIndented = true });
                File.WriteAllText(filePath, jsonString);
            }
        }



        static void Main(string[] args)
        {
            // ReadFiles();
            //GenerateDocuments();
            //GenerujPlik();  zadanie1
            ////zadanie2();
            ////Zadanie3();
            //var data = JsonSerializer.Deserialize<List<PopulationData>>(File.ReadAllText("db.json")) ?? new List<PopulationData>();
            //ShowPopulationDifference(data, "India", 1970, 2000);
            //ShowPopulationDifference(data, "United States", 1965, 2010);
            //ShowPopulationDifference(data, "China", 1980, 2018);

            FilePersonRepository repo = new FilePersonRepository();
            repo.SavePerson(new Person { Name = "Adam", Age = 21, Email = "adam@wp.pl" });
            var people = repo.LoadPeople();
            Console.WriteLine("Załadowane osoby:");
            foreach (var person in people)
                {
                 Console.WriteLine($"{person.Name}, {person.Age}, {person.Email}");
                }

        }
    }
}