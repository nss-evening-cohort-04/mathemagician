using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathMagician.Numbers
{
    public class FibonacciNumber : NaturalNumber
    {
        private int[] BaseSequence { get; set; }
    

        public FibonacciNumber()
        {
            First = 1;
            Step = 1;
        }
        public override int GetNext(int current)
        {
            return current;
        }
        public override int[] GetSequence(int how_many)
        {
            int[] fibNums = new int[how_many];

            fibNums[0] = GetFirst();

            for (int i = 2; i < 10; i++)
            {
                fibNums[i] = GetNext(fibNums[i - 2]) + GetNext(fibNums[i - 1]);
            }

            return fibNums;
        }
    }
}
