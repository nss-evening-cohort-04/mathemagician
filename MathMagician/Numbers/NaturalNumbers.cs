using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathMagician.Numbers
{
    public class NaturalNumbers : Integer
    {
        private int First { get; set; }

        public NaturalNumbers()
        {
            First = 1;
            //this.First = 1;
        }

        public int GetFirst()
        {
           return First;
        }

        public int GetNext(int current)
        {
            return current + 1;
        }

        public int[] GetSequence(int how_many)
        {
            int[] sequence = { };
            for (int i = 1; i < how_many; i++)
            {
                sequence[i - 1] = i;
            }
            return sequence;
        }

        public string printNumbers(int[] how_many)
        {
            throw new NotImplementedException();
        }
    }
}
