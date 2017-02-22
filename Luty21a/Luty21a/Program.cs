using System;

namespace Luty21a
{
    /*
       Zad.1
       Stwórz interfejs IPojazd w którym znajdować się będą trzy metody 
       typu void i pobierające po jednym parametrze o nazwach 
       UstawRodzajPojazdu, UstawIloscKol, UstawIloscMiejsc.
       Stwórz klasę Ciezarowka dziedziczącą po interfejsie. 
       Za pomocą metod przypisz do pól prywatnych wartości. 
       Stwórz metody, które będą zwracać te pola prywatne, 
       gdzie nazwy to PobierzRodzajPojazdu, PobierzIloscKol, PobierzIloscMiejsc. 
       Stwórz klasę o nazwie Osobowka i za pomocą własności zdefiniuj 
       RodzajPojazdu, IloscKol i IloscMiejsc. 
       Która metoda jest szybsza do zaimplementowania? 
       Dlaczego zwracamy wartości przez pola prywatne lub przypisujemy do pól 
       prywatnych? Jaka to jest nazywane w językach obiektowych.
        
       Zad.2
       Stwórz klasę Osoba. Zdefiniuj w niej trzy własności(get i set) 
       – Imię, Nazwisko, Wiek. 
       W klasie pochodnej Student przedefiniuj metodę ToString() tak, 
       aby zwracała Imie, Nazwisko i Wiek.

       Zad.3 
       Stwórz klasę Sportowiec z metodami o własności abstract 
       i typie void i nazwach Bieganie, Skakanie, Plywanie. 
       Stwórz trzy klasy UsainBolt, LeBronJames, MichaelPhelps, 
       które dziedziczą po Sportowiec i przedefiniuj za pomocą override metody. 
       Niech metody zwracają do konsoli według prawdy umiejętności 
       tych trzech osób w danej dziedzinie.
             
             */


    class Program
    {
        static void Main(string[] args)
        {
            Ciezarowka ciez = new Ciezarowka();
            ciez.UstawRodzajPojazdu("duzy TIR");

            Osobowka osob = new Osobowka();
            osob.RodzajPojazdu = "osobówka";
            osob.IloscKol = 4;
            osob.IloscMiejsc = 5;
            
            Console.WriteLine("nazwa ciężarówki {0}", ciez.PobierzRodzajPojazdu());
            Console.WriteLine("nazwa osobówki {0}", osob.RodzajPojazdu);

            Console.WriteLine();

            Student student = new Student();
            student._imie = "Adam";
            Console.WriteLine(student);


            Console.ReadKey();

            

        }
    }
}
