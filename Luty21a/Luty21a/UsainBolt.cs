using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Luty21a
{
    class UsainBolt : Sportowiec
    {
        public override void Bieganie()
        {
            Console.WriteLine("Mistrz olimpijski w sprincie z Jamajki");
        }

        public override void Plywanie()
        {
            Bieganie();
        }

        public override void Skakanie()
        {
            Bieganie();
        }
    }
}
