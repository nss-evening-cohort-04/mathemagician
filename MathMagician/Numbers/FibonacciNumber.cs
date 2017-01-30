using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathMagician.Numbers
{
    public class FibonacciNumber : NaturalNumber
    {
        //could hold 1, 1, 2, 3, 5, 8, ...
        private int[] BaseSequence { get; set; }

        public FibonacciNumber()
        {
            First = 1;
            BaseSequence =new int[] { 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377, 610, 987, 1597, 2584, 4181, 6765, 10946, 17711, 28657, 46368, 75025, 121393, 196418, 317811, 514229 };
        }

        public override int GetNext(int currentIndex)
        {
            return BaseSequence[currentIndex];
        }

        public override int[] GetSequence(int how_many)
        {
            int[] numbers = new int[how_many];
            numbers[0] = GetFirst(); // i = 1
            for (int i = 1; i < numbers.Length; i++)
            {

                numbers[i] = GetNext(i);

            }

            return numbers;
        }

    }
}
