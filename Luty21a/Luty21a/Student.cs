using System;

namespace Luty21a
{
    class Student : Osoba
    {
        public override string ToString()
        {
            return "Imie: " + _imie + 
                   "Nazwisko: " + _nazwisko + 
                   "Wiek: " + _wiek;
            
        }
    }
}
