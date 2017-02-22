using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace example
{
   public class Service
    {
        private readonly Array _array=new Array();
        private readonly Print _print=new Print();

        public void Init()
        {
            int[] numbers = _array.InitArray();
            _print.PrintArray(numbers);
        }
    }
}
