using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Luty21a
{
    class MichaelPhelps : Sportowiec
    {
        public override void Bieganie()
        {
            Console.WriteLine(rybka);
        }

        public override void Skakanie()
        {
            Plywanie();
        }

        public override void Plywanie()
        {
            Console.WriteLine("pływak");
        }
    }
}
