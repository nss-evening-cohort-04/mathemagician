using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathMagician.Numbers
{
    public class FibonacciNumber : Integer
    {
        private int First { get; set; }

        public FibonacciNumber()
        {
            First = 1;
        }

        public int GetFirst()
        {
            return First;
        }

        public int GetNext(int current)
        {

            return current + 1;
        }

        public int[] GetSequence(int howMany)
        {
            int[] numbers = new int[howMany];
            numbers[0] = 1;
            int a = 0;
            int b = 1;

            for (int i = 1; i < numbers.Length; i++)
            {
                int temp = a;
                a = b;
                b = temp + b;
                numbers[i] = b;
            }

            return numbers;
        }

        public string PrintNumbers(int[] numberArray)
        {
            return String.Join(" ", numberArray);
        }
    }
}
