using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathMagician.Numbers
{
    public class OddNumber : NaturalNumber
    {
        public OddNumber()
        {
            First = 1;
        }

        public override int GetNext(int current)
        {
            return current + 2;
        }
    }
}
