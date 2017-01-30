using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathMagician.Numbers
{
    public class FibonacciNumber : NaturalNumber
    {
        // I need to use the word "new" in this case.
        // Says using "Integer" does not implement
        // So I've changed to NaturalNumber
        // Inheriting from NaturalNumber forces me to use "new"
        private new int First { get; set; }

        public FibonacciNumber()
        {
            First = 1;
        }

        public new int GetFirst()
        {
            return First;
        }

        public int GetNext(int currentFibonacci, int previousFibonacci)
        {
            // The next fibonacci number is whatever number you're on (current), plus the number right before it (previous)
            // For example, if my current Fibonacci number is 5, then:
            // 5 (current) + 3 (previous) = 8
            // Therefore:
            return currentFibonacci + previousFibonacci;
        }

        public int[] GetSequence(int[] how_many)
        {
            
        }


    }
}
