using System;

namespace ZadanieDrugie
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] tablica = {5, 6, 3, 2, 9, 4, 8, 1, 7};//deklaruję jakąś tablicę
            var sortowanie = new Sortowanie();

            var wyp = new Wypisz();//instancja klasy Wypisz i na dole metoda
            wyp.WypiszNaEkran(tablica);

            Console.WriteLine();

            sortowanie.SortowanieBabelkowe(tablica);

            wyp.WypiszNaEkran(tablica);//po sortowaniu


            Console.ReadKey();
        }
    }
}
