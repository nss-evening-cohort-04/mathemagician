using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathMagician.Numbers
{
    public class FibonacciNumber : NaturalNumber
    {
        public int GetNext(int current, int previous)
        {
            return current + previous;
        }

        public override int[] GetSequence(int how_many)
        {
            int[] fibonacciNums = new int[how_many];
            fibonacciNums[0] = GetFirst(); // set first
            if (how_many >=2)
            {
                fibonacciNums[1] = 1;
            } // set second
            for (int i = 2; i < how_many; i++)
            {
                fibonacciNums[i] = fibonacciNums[i-1] + fibonacciNums[i-2];
            } // set those after second
            return fibonacciNums;
        }
    }
}
