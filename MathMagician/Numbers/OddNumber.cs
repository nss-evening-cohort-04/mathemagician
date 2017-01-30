using MathMagician.Numbers;
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
            if((current % 2) == 0)
            {
                current = current + 1;
            }
            else
            {
                current = current + 2;
            }
            return current;
        }

        public int[] GetSequence(int howMany)
        {
            throw new NotImplementedException();
        }

        public string PrintNumbers(int[] howMany)
        {
            throw new NotImplementedException();
        }
    }
}
