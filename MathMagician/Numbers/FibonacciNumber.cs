using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathMagician.Numbers
{
    public class FibonacciNumber : NaturalNumber
    {
        //Could hold 1, 1, 2, 3, 5, 8, ....
        public int GetNext(int current, int prev)
        {
            return current + prev;
        }

        public override int[] GetSequence(int how_many)
        {
            int[] fiboNum = new int[how_many];
            fiboNum[0] = GetFirst(); // BEGIN FIB SQNC
            if (how_many >= 2)
            {
                fiboNum[1] = 1;
            } 
            for (int i = 2; i < how_many; i++)
            {
                fiboNum[i] = fiboNum[i - 1] + fiboNum[i - 2];
            } 
            return fiboNum;
        }
    }
}