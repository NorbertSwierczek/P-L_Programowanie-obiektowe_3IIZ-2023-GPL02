using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projekt
{
    internal class Uzytkownik
    {
        public string Nazwa {  get; set; }
        public string Stanowisko { get; set; }

        public Uzytkownik(string nazwa, string stanowisko)
        {
            Nazwa = nazwa;
            Stanowisko = stanowisko;
        }
    }
}
