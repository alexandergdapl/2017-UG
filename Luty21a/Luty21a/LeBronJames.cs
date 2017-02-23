using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Luty21a
{
    class LeBronJames : Sportowiec
    {
        public override void Bieganie()
        {
            Console.WriteLine("LeBron James biega wolno, ale za to dobrze skacze");
        }

        public override void Skakanie()
        {
            Console.WriteLine("koszykarz dobrze skacze... ;)");
        }

        public override void Plywanie()
        {
            Console.WriteLine();
            Bieganie();
            Console.WriteLine("...a poza tym chyba nie umie pływać.");
        }
    }
}
