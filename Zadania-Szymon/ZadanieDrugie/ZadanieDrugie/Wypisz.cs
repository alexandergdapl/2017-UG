using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZadanieDrugie
{
    class Wypisz
    {
        public void WypiszNaEkran(int[] tablica)
        {
            foreach (var liczby in tablica)
            {
                Console.Write($"{liczby}  ");
            }
        }
    }
}
