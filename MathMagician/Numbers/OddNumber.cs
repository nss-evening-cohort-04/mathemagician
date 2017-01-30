using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathMagician.Numbers
{
    public class OddNumber : NaturalNumber
    {
        //don't want them to access it outside of the class//
        public OddNumber()
        {
            FirstNumber = 1;
            Step = 2;
        }
    }
}
