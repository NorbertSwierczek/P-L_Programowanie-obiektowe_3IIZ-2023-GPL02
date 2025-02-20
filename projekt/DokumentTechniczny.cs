using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projekt
{
    internal class DokumentTechniczny : Dokument
    {
        public string Opis; 
        public DokumentTechniczny(int id, string tytul, string autor, string opis) : base(id, tytul, autor)
        {
            this.Opis = opis;
        }
        public void Wyswietl()
        {
            Console.WriteLine($"[Kadrowy] {Tytul} - {Autor}, Opis: {Opis}, Data: {DataUtworzenia}");
        }
    }
}
