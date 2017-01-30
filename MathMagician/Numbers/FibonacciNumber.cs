using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathMagician.Numbers
{
    public class FibonacciNumber : NaturalNumber
    {
        private int Current { get; set; }

        public FibonacciNumber()
        {
            First = 1;
            Current = 1;
        }

        public int GetCurrent()
        {
            return Current;
        }

        public override int[] GetSequence(int how_many)
        {
            int[] fibArray = new int[how_many];
            fibArray[0] = GetFirst();
            for (var i = 1; i < how_many; i++)
            {
                fibArray[i] = GetCurrent();
                Current = fibArray[i] + fibArray[i - 1];
            }
            return fibArray;
        }
    }
}
