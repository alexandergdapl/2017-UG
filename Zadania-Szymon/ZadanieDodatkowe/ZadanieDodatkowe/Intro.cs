using System;

namespace ZadanieDodatkowe
{
    class Intro
    {
        string a = "Podany znak jest liczbą.";
        string b = "Podany znak jest Wielką literą.";
        string c = "Podany znak jest małą literą.";

        public void DzienDobry()
        {
            Console.Write("Wprowadź znak: ");
            var x = Console.ReadLine();
            

            int wartosc;

            if (int.TryParse(x, out wartosc))
            {
                Console.WriteLine(a);
            }

            
            




        }

    }
}
