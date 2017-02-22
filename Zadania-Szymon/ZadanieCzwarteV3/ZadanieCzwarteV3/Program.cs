using System;

namespace ZadanieCzwarteV3
{
    class Program
    {
        static void Main(string[] args)
        {
            new Service().StartChlopcy();
            Console.WriteLine();
            new Service().StartDziewczyny();

            Console.WriteLine("_____________________________________\n");


            new Service().ScalanieTablic();

            Console.ReadKey();
        }
    }
}
