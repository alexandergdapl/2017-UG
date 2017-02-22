using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace example
{
    public class Print
    {
        public void PrintArray(int[] array)
        {
            foreach (var i in array)
            {
                Console.WriteLine(i);
            }
        }
    }
}
