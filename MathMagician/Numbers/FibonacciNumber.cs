using MathMagician.Numbers;
using System;
using System.Collections.Generic;
using System.Diagnostics;
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
            First = 0;
        }
        public int GetFirst()
        {
            return First;
        }

        public int GetNext(int current)
        {
            return current + First;
        }
        // Fib Sequence 0, 1, 1, 2, 3, 5, 8, 13, 21, 34
        public int[] GetSequence(int howMany)
        {
            int firstNum = 0;
            int secondNum = 1;
            int[] result = new int[howMany];
            result[0] = GetFirst();
            for(int i = 0; i < howMany; i++)
            {
                int temp = firstNum;
                result[i] = temp;
                firstNum = secondNum;
                secondNum += temp;
            }
            Trace.WriteLine(result);
            return result;
        }

        public string PrintNumbers(int[] howMany)
        {
            return String.Join(" ", howMany);
        }
    }
}
