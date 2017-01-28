using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathMagician.Numbers
{
    public class PrimeNumber : Integer
    {
        private int First { get; set; }

        public PrimeNumber()
        {
            First = 2;
        }

        public int GetFirst()
        {
            return First;
        }

// code not finished from here down 1/28 @1:47pm
        public int GetNext(int current)
        {
            return current + 1;
        }

        public int[] GetSequence(int howMany)
        {
            int[] numbers = new int[howMany];

            numbers[0] = GetFirst();

            for (int i = 1; i < numbers.Length; i++)
            {
                numbers[i] = GetNext(numbers[i - 1]);
            }

            return numbers;
        }

        public string PrintNumbers(int[] numberArray)
        {
            return String.Join(" ", numberArray);
        }
    }
}
