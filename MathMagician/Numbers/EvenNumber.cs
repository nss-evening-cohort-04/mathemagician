using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathMagician.Numbers
{
    public class EvenNumber : NaturalNumber
    {
        private int first { get; set; }

        public EvenNumber()
        {
            first = 2;
            // this.first = 2;
        }

        public override int GetFirst()
        {
            return first;
        }

        public override int GetNext(int current)
        {
            return current + 2;
        }
    }
}
