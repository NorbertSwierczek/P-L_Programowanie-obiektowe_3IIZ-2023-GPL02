using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projekt
{
    internal class Dokument
    {        
		public int Id { get; set; }
        public string Tytul { get; set; }
        public string Autor { get; set; }
        public DateTime DataUtworzenia { get; set; }
        public bool Archiwizacja { get; set; }


        public Dokument(int id, string tytul, string autor)
        {
            Id = id;
            Tytul = tytul;
            Autor = autor;
            DataUtworzenia = DateTime.Now;
            Archiwizacja = false;
        }
        public void Wyswietl()
        {
            Console.WriteLine($"---===DOKUMENT===---\nNumer dokumentu: {Id}\nTytuł: {Tytul}\nAutor: {Autor}\nData utworzenia: {DataUtworzenia}\nCzy dokument jest zarchiwizowany? {Archiwizacja}");
        }
}
}
