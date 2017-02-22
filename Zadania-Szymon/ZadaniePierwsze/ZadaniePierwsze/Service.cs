using System;

namespace ZadaniePierwsze
{
    public class Service : IManager
    {
        private int X { get; set; }
        private string t { get; } = "TAK";
        private string n { get; } = "NIE";

        public void CheckNumber(int x)
        {
            this.X = x;

            string result = x % 2 == 0 ? t: n;

            Console.WriteLine(result);
        }

        public void text()
        {
            Console.WriteLine("Sprawdzam liczbę.");
        }
    }
}