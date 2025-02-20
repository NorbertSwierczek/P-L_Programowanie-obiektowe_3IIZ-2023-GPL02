using projekt;
using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void Main()
    {
        DokumentyCzynnosci repo = new DokumentyCzynnosci();
        repo.WczytajZPliku();

        Console.WriteLine("--==ZALOGUJ==--\nImię i nazwisko: ");
        string login = Console.ReadLine();
        Console.WriteLine("Poziom konta (Administrator, Pracownik, Gość): ");
        string poziomKonta = Console.ReadLine();
        Uzytkownik zalogowany = new Uzytkownik(login, poziomKonta);
        bool menu = true;
        while (menu)
        {
            Console.WriteLine("--==MENU==--");
            Console.WriteLine("1. | Dodaj dokument.");
            Console.WriteLine("2. | Usuń dokument.");
            Console.WriteLine("3. | Edytuj dokument.");
            Console.WriteLine("4. | Wyświetl dokument.");
            Console.WriteLine("5. | Wyloguj się.");
            Console.WriteLine("Wybierz opcję: ");
            string opcja = Console.ReadLine();

            switch (opcja)
            {
                case "1":
                    DodajDokument(repo, zalogowany);
                    break;
                case "2":
                    UsunDokument(repo, zalogowany);
                    break;
                case "3":
                    EdytujDokument(repo, zalogowany);
                    break;
                case "4":
                    repo.WyswietlDokumenty();
                    break;
                case "5":
                    menu = false;
                    repo.ZapiszDoPliku();
                    break;
            }

            static void DodajDokument(DokumentyCzynnosci repo, Uzytkownik uzytkownik)
            {
                Console.WriteLine("\n--== DODAWANIE DOKUMENTU ==--");
                Console.Write("Podaj ID dokumentu: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Podaj tytuł: ");
                string tytul = Console.ReadLine();
                Console.Write("Podaj autora: ");
                string autor = uzytkownik.Nazwa;

                Console.WriteLine("Wybierz typ dokumentu:");
                Console.WriteLine("1. Dokument Finansowy");
                Console.WriteLine("2. Dokument Kadrowy");
                Console.WriteLine("3. Dokument Techniczny");
                Console.Write("Twój wybór: ");
                string typ = Console.ReadLine();

                Dokument nowyDokument = null;

                switch (typ)
                {
                    case "1":
                        Console.Write("Podaj kwotę: ");
                        decimal kwota = decimal.Parse(Console.ReadLine());
                        nowyDokument = new DokumentFinansowy(id, tytul, autor, kwota);
                        break;
                    case "2":
                        Console.Write("Podaj kwotę: ");
                        decimal kwota1 = decimal.Parse(Console.ReadLine());
                        nowyDokument = new DokumentKadrowy(id, tytul, autor, kwota1);
                        break;
                    case "3":
                        Console.Write("Podaj opis techniczny: ");
                        string opis = Console.ReadLine();
                        nowyDokument = new DokumentTechniczny(id, tytul, autor, opis);
                        break;
                }

                repo.DodajDokument(nowyDokument, uzytkownik);
                Console.WriteLine("Dokument został dodany.");
            }

            static void UsunDokument(DokumentyCzynnosci repo, Uzytkownik uzytkownik)
            {
                Console.Write("Podaj ID dokumentu do usunięcia: ");
                int id = int.Parse(Console.ReadLine());

                repo.UsunDokument(id, uzytkownik);
                Console.WriteLine("Dokument został usunięty.");
            }

            static void EdytujDokument(DokumentyCzynnosci repo, Uzytkownik uzytkownik)
            {
                Console.Write("Podaj ID dokumentu do edycji: ");
                int id = int.Parse(Console.ReadLine());

                Console.Write("Nowy tytuł: ");
                string nowyTytul = Console.ReadLine();
                Console.Write("Nowy autor: ");
                string nowyAutor = Console.ReadLine();
                Console.Write("Czy dokument ma być zarchiwizowany?): ");
                bool nowaArchiwizacja = bool.Parse(Console.ReadLine());

                repo.EdytujDokument(id, nowyTytul, nowyAutor, nowaArchiwizacja, uzytkownik);
                Console.WriteLine("Dokument został zaktualizowany.");
            }
        }
    }

}