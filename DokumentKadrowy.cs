using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projekt
{
    internal class DokumentKadrowy : Dokument
    {
        public decimal Kwota; 
        public DokumentKadrowy(int id, string tytul, string autor, decimal kwota) : base(id, tytul, autor)
        {
            this.Kwota = kwota;
        }
        public void Wyswietl()
        {
            Console.WriteLine($"[Kadrowy] {Tytul} - {Autor}, Kwota: {Kwota}, Data: {DataUtworzenia}");
        }
    }
}
