using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathMagician.Numbers
{
    public class Odd : NaturalNumber
    {
        private int First { get; set; }

        public Odd()
        {
            First = 1;
        }

        public override int GetFirst()
        {
            return First;
        }

        public override int GetNext(int current)
        {
            return current + 2;
        }

        public override int[] GetSequence(int how_many)
        {
            int[] oddNums = new int[how_many];
            for (int i = 1; i <= how_many; i++)
            {
                oddNums[i - 1] = i * 2 - 1;
            }
            return oddNums;
        }
    }
}
