using System;

namespace ZadaniePierwsze
{
    class Program
    {
        static void Main(string[] args)
        {
            var sprawdzam = new Service();
            sprawdzam.text();
            sprawdzam.CheckNumber(15); //jako argument-liczba do sprawdzenia
            
            Console.ReadKey();
        }
    }
}
