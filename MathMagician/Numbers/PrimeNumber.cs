using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathMagician.Numbers
{
    public class PrimeNumber: FibonacciNumber
    {
        private int[] BaseSequence { get; set; }

        public PrimeNumber()
        {
            First = 2;
            BaseSequence = new int[] { 2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 31, 37, 41, 43, 47, 53, 59, 61, 67, 71, 73, 79, 83, 89, 97, 101, 103, 107, 109, 113 };
        }

        public override int GetNext(int currentIndex)
        {
            return BaseSequence[currentIndex];
        }
    }
}
