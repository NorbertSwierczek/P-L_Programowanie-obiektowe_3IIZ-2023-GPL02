using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class BankAccount
    {
        private decimal saldo;
        private string wlasciciel;



        public decimal Saldo
        {
            get { return saldo; }
            private set { saldo = value; }
        }

        public string Wlasciciel
        {
            get { return wlasciciel; }
            set { wlasciciel = value; }
        }

        public BankAccount(decimal saldo, string wlasciciel)
        {
            Wlasciciel = wlasciciel;
            Saldo = saldo;
        }

        public void Wplata(decimal kwota) {
            if (kwota < 0) { Console.WriteLine("Za mała kwota wpłaty!"); return; }
            Saldo += kwota;
            Console.WriteLine($"Wpłacono: {kwota:C}" + $"Na koncie: {Saldo:C}");
        }

        public void Wyplata(decimal kwota)
        {
            if (kwota < 0) { Console.WriteLine("Za mała kwota wypłaty!"); return; }
            if (kwota>Saldo) { Console.WriteLine("Za mało środków na koncie!"); return; }
            Saldo -= kwota;
            Console.WriteLine($"Wypłacono: {kwota:C}" + $"Na koncie: {Saldo:C}");
        }

        public void View()
        {
            Console.WriteLine($"Właściciel: {wlasciciel}" + $"\tSaldo: {saldo:C}");
        }
    }
}
