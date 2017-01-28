using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathMagician.Numbers
{
    public class NaturalNumber : Integer
    {
        protected int First { get; set; }
        protected int Step { get; set; }

        public NaturalNumber()
        {
            First = 1;
            Step = 1;
        }

        public virtual int GetFirst()
        {
            return First;
        }

        public virtual int GetNext(int current)
        {
            return current + Step;
        }

        public virtual int[] GetSequence(int how_many)
        {
            int[] naturalNums = new int[how_many];
            naturalNums[0] = GetFirst();
            for (int i = 1; i < how_many; i++)
            {
                naturalNums[i] = GetNext(naturalNums[i - 1]);
            }
            return naturalNums;
        }

        public string PrintNumbers(int[] how_many)
        {
            return String.Join(" ", how_many);
        }
    }
}
