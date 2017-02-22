using System;

namespace ZadanieTrzecieV2
{
    class DrukujTablice : RandomTabNumber
    {
        //! Nie wiem jak przekazać wypełnioną tablicę z klasy RandomTabNumber...

        public void DrukujTab()
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
