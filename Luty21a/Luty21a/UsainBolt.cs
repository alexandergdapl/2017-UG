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
            throw new NotImplementedException();
        }

        public override void Skakanie()
        {
            throw new NotImplementedException();
        }
    }
}
