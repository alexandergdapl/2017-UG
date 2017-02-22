using System;

namespace ZadanieCzwarteV3
{
    class DrukujTablice
    {
        public void DrukTablicy(string[] tablica)
        {
            foreach (var i in tablica)
            {
                Console.WriteLine(i);
            }
        }
    }
}
