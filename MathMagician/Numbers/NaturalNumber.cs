using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathMagician.Numbers
{
    public class NaturalNumber : Integer
    {

        // FYI EVENS & ODDS ARE ALSO NATURAL NUMBERS SO THEY CAN INHERIT FROM THIS
        public int GetFirst()
        {
            return 1;
        }

        public int GetNext(int current)
        {
            throw new NotImplementedException();
        }

        public int[] GetSequence(int howMany)
        {
            throw new NotImplementedException();
        }

        public string printNumbers(int[] howMany)
        {
            throw new NotImplementedException();
        }
    }
}
