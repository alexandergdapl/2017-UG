using System;
using System.Globalization;
using System.Linq;

namespace OsobyPlikMaleWielkie
{
    class Program
    {
        static void Main(string[] args)
        {
            DownloadDataFromFile tablica = new DownloadDataFromFile();

            Console.ForegroundColor = ConsoleColor.DarkCyan;

            //po pobraniu linijek z pliku wydrukowuję je na ekran
            tablica.PrintArray();
            Console.WriteLine();

            //trimuję od @ do końca i drukuję efekt
            tablica.TrimAfterMonkey();
            tablica.PrintArray();

            Console.WriteLine();

            //zamieniam kropkę na spację i drukuję efekt
            tablica.ReplaceDotToSpace();
            tablica.PrintArray();

            Console.WriteLine();

            //zmieniam pierwsze litery na Wielkie
            tablica.FirstCharToUpper();
            Console.WriteLine("\nZgodnie z treścią zadania tylko to poniżej ma się wydrukować na ekran:\n");

            Console.ResetColor();

            tablica.PrintArray();

            //zapis wyniku do pliku txt
            tablica.RecordToFile();





            






            Console.ReadKey();
        }
    }
}
