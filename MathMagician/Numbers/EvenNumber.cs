using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathMagician.Numbers
{
    public class EvenNumber : NaturalNumber
    {
        //public override int First { get; set; }
        public EvenNumber()
        {
            First = 2;
            Step = 2;
        }

    }
}
