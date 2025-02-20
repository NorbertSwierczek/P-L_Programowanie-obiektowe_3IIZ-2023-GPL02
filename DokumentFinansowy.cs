using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace projekt
{
    internal class DokumentFinansowy : Dokument
    {
        public decimal Kwota;
        public DokumentFinansowy(int id, string tytul, string autor, decimal kwota) : base(id, tytul, autor)
        {
            this.Kwota = kwota;
        }
        public void Wyswietl()
        {
            Console.WriteLine($"[Kadrowy] {Tytul} - {Autor}, Kwota: {Kwota}, Data: {DataUtworzenia}");
        }
    }
}
