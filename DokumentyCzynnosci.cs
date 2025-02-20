using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace projekt
{
    internal class DokumentyCzynnosci
    {
        private List<Dokument> dokumenty = new List<Dokument>();
        private string plik = "dokumenty.txt";


        public void DodajDokument(Dokument dokument, Uzytkownik uzytkownik)
        {
            if (uzytkownik.Stanowisko == "Administrator" || uzytkownik.Stanowisko == "Pracownik")
            {
                dokumenty.Add(dokument);
                ZapiszDoPliku();
            }
            else 
            {
                Console.WriteLine("Nie masz upawnień do wykonania czynności! (Dodaj dokument)"); 
            }
        } 

        public void UsunDokument(int id, Uzytkownik uzytkownik)
        {
            if (uzytkownik.Stanowisko == "Administrator")
            {
                foreach (var dokument in dokumenty)
                {
                    if (dokument.Id == id)
                    {
                        dokumenty.Remove(dokument);
                        break;

                    }
                }
            }
            else
            {
                Console.WriteLine("Nie masz upawnień do wykonania czynności! (Usuń dokument)");
            }
        }

        public Dokument WczytajDokument(int id)
        {
            foreach (var dokument in dokumenty)
            {
                if (dokument.Id == id)
                {
                    return dokument;
                }
            }
            return null;
        }

        public void EdytujDokument(int id, string nowyTytul, string nowyAutor, bool nowaArchiwizacja, Uzytkownik uzytkownik)
        {
            if (uzytkownik.Stanowisko == "Administrator")
            {
                Dokument dokument = WczytajDokument(id);
                dokument.Tytul = nowyTytul;
                dokument.Autor = nowyAutor;
                dokument.Archiwizacja = nowaArchiwizacja;
            } 
        }



        public void WyswietlDokumenty()
        {
            foreach (var dokument in dokumenty)
            {
                dokument.Wyswietl();
            }
        }

        public void ZapiszDoPliku()
        {
            List<string> linie = new List<string>();

            foreach (var dokument in dokumenty)
            {
                linie.Add($"{dokument.Id}|{dokument.Tytul}|{dokument.Autor}|{dokument.DataUtworzenia}");
            }

            File.WriteAllLines(plik, linie);
           
        }

        public void WczytajZPliku()
        {
                string[] linie = File.ReadAllLines(plik);
                
                foreach (var linia in linie)
                {
                    string[] dane = linia.Split('|');
                    {
                        int id = int.Parse(dane[0]);
                        string tytul = dane[1];
                        string autor = dane[2];
                        DateTime dataUtworzenia = DateTime.Parse(dane[3]);

                        Dokument dokument = new Dokument(id, tytul, autor);
                        dokument.DataUtworzenia = dataUtworzenia;

                        dokumenty.Add(dokument);
                    }
                }
        }

    }
}
