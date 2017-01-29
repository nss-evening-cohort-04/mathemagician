using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathMagician.Numbers
{
    public class FibonacciNumber : NaturalNumber
    {
        //could hold 1, 1, 2, 3, 5, 8, 13, 21, 34...
        private int[] BaseSequence { get; set; }

        public int GetFirst()
        {
            throw new NotImplementedException();
        }

        public int GetNext(int current)
        {
            throw new NotImplementedException();
        }

        public int[] GetSequence(int how_many)
        {
            throw new NotImplementedException();
        }

        public string PrintNumbers(int[] how_many)
        {
            throw new NotImplementedException();
        }
    }
}
