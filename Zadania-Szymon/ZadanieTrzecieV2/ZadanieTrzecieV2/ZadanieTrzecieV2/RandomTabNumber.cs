using System;

namespace ZadanieTrzecieV2
{
    public class RandomTabNumber
    {
        public int[,] tablica = new int[4, 4];
        
        public void WypelnijTablice()
        {
            Random losuj = new Random();

            for (int i = 0; i < tablica.GetLength(0); i++)
            {
                for (int j = 0; j < tablica.GetLength(1); j++)
                {
                    tablica[i, j] = losuj.Next(1, 20);
                }
            }
        }



        public void DrukujTabl()
        {
            for (int i = 0; i < tablica.GetLength(0); i++)
            {
                for (int j = 0; j < tablica.GetLength(1); j++)
                {
                    Console.Write("{0,3} |", tablica[i, j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}
