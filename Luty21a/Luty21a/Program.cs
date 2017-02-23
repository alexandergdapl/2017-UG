using System;

namespace Luty21a
{
    
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("______Zadanie 1________________________________");
            Ciezarowka ciez = new Ciezarowka();
            ciez.UstawRodzajPojazdu("duzy TIR");
            ciez.UstawIloscKol(16);
            ciez.UstawIloscMiejsc(2);
            
            Console.WriteLine("ciężarówka: {0}, ilość kół: {1}, ilość miejsc: {2}", 
                ciez.PobierzRodzajPojazdu(), 
                ciez.PobierzIloscKol(), 
                ciez.PobierzIloscMiejsc());


            Osobowka osob = new Osobowka();
            osob.RodzajPojazdu = "taksówka";
            osob.IloscKol = 4;
            osob.IloscMiejsc = 5;

            Console.WriteLine("\nosobówka {0}, ilośc kół: {1}, ilość miejsc: {2}", 
                osob.RodzajPojazdu, osob.IloscKol, osob.IloscMiejsc);

            Console.WriteLine("\n______Zadanie 2________________________________");

            Student student = new Student();
            student._imie = "Adam";
            student._nazwisko = "Marczewski";
            student._wiek = 20;
            Console.WriteLine(student);

            Console.WriteLine("\n______Zadanie 3________________________________");

            LeBronJames Le = new LeBronJames();
            Le.Skakanie();
            new MichaelPhelps().Plywanie();
            new UsainBolt().Bieganie();


            Console.ReadKey();

            

        }
    }
}
