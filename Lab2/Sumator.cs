using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Sumator
    {
        private int[] liczby = [];

        public int Suma()
        {
            return liczby.Sum();
        }
            
        public int SumaPodziel2()
        {
            return liczby.Where(x => x%2 ==0).Sum();
        }

        public Sumator(int[] liczby)
        {
            this.liczby = liczby;
        }

        public int IleElementow()
        {
            return liczby.Count();
        }

        public void WszystkieElementy()
        {
            foreach (int i in liczby)
            {
                Console.WriteLine(i);
            }
        }

        public void IndeksyElementy(int lowIndex, int highIndex)
        {
            for (int i = lowIndex; i <= highIndex; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}