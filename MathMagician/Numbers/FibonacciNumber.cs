using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathMagician.Numbers
{
    public class FibonacciNumber : NaturalNumber
    {
        private int First { get; set; }

        public FibonacciNumber()
        {
            First = 1;
        }

        public override int GetFirst()
        {
            return First;
        }

        public int GetNext(int current, int previous)
        {
            return current + previous;
        }

        public override int[] GetSequence(int how_many)
        {
            int[] fibonacciNums = new int[how_many];
            fibonacciNums[0] = 1;
            fibonacciNums[1] = 1;
            for (int i = 2; i < how_many; i++)
            {
                fibonacciNums[i] = fibonacciNums[i-1] + fibonacciNums[i-2];
            }
            return fibonacciNums;
        }
    }
}
