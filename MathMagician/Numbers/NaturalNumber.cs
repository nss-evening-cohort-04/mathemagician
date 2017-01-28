using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathMagician.Numbers
{
    public class NaturalNumber : Integer
    {
        private int First { get; set; }

        public NaturalNumber()
        {
            First = 1;
            //same as this.First = 1;
        }

        public int GetFirst()
        {
            return First;
        }

        public int GetNext(int current)
        {
            return current;
        }

        public int[] GetSequence(int how_many)
        {
           return how_many[];
        }

        public string PrintNumbers(int[] how_many)
        {
           return how_many[];
        }
    }
}
