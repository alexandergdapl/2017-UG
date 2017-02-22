using System;

namespace ZadanieCzwarteV3
{
    class DrukujTablice2
    {
        public void DrukTablicy2(string [,] tablica)
        {
            //foreach (var parka in tablica)
            //{
            //    Console.WriteLine("{0}", parka);
            //}

            //for (int i = 0; i < tablica.GetLength(0); i++)
            //{
            //    for (int j = 0; j < tablica.GetLength(1); j++)
            //    {
            //        Console.Write("{0} * ",tablica[i, j]);
                    
            //    }
            //}

            //Console.WriteLine("\n");
            
            //Console.WriteLine("{0} - {1}", tablica[0,0],  tablica[0,1]);
            //Console.WriteLine("{0} - {1}", tablica[1,0],  tablica[1,1]);
            //Console.WriteLine("{0} - {1}", tablica[2,0],  tablica[2,1]);
            //Console.WriteLine("{0} - {1}", tablica[3,0],  tablica[3,1]);
            //Console.WriteLine("{0} - {1}", tablica[4,0],  tablica[4,1]);

            //Console.WriteLine("\n");

            //w poleceniu było napisane aby za pomocą konkatenacji...
            //Console.WriteLine(tablica[0, 0] + " - " + tablica[0, 1]);
            //Console.WriteLine(tablica[1, 0] + " - " + tablica[1, 1]);
            //Console.WriteLine(tablica[2, 0] + " - " + tablica[2, 1]);
            //Console.WriteLine(tablica[3, 0] + " - " + tablica[3, 1]);
            //Console.WriteLine(tablica[4, 0] + " - " + tablica[4, 1]);

            for (int i = 0; i < tablica.GetLength(0); i++)
            {
                Console.WriteLine(tablica[i, 0] + " - " + tablica[i, 1]);
            }

        }
    }
}
