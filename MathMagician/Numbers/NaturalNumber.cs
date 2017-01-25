using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathMagician.Numbers
{
    public class NaturalNumber : Integer
    {
        //don't want them to access it outside of the class//
        private int FirstNumber { get; set; }

        public NaturalNumber()
        {
            FirstNumber = 1;
            //this.FirstNumber = 1;
        }

        public int GetFirst()
        {
            return FirstNumber;
        }

        public int GetNext(int current)
        {
            throw new NotImplementedException();
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
