using System;

namespace ZadanieTrzecieV2
{
    class Program
    {
        static void Main(string[] args)
        {
            var wypelnij = new RandomTabNumber();
            wypelnij.WypelnijTablice();
            
            //! metoda z klasy DrukujTablice:
            var wydrukuj = new DrukujTablice();
            wydrukuj.DrukujTab();

            //! metoda z klasy RandomTabNumber:
            wypelnij.DrukujTabl();
            wypelnij.DrukujTabl();

            wypelnij.WypelnijTablice();// Jak na nowo wypełnić tablicę?
            wypelnij.WypelnijTablice();
            wypelnij.DrukujTabl();
            wypelnij.DrukujTabl();



            Console.ReadKey();
        }
    }
}
