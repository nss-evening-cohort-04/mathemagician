using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathMagician.Numbers
{
    public class OddNumber : Integer
    {
        private int First { get; set; }

        public OddNumber()
        {
            First = 1;
        }

        public int GetFirst()
        {
            return First;
        }

        public int GetNext(int current)
        {
            return current + 2;
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
