using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathMagician.Numbers
{
    public class EvenNumber : NaturalNumbers
    {
        private int First { get; set; }

        public EvenNumber()
        {
            First = 2;
            Step = 2;
            GetSequence(5);
            int[] numbers = new int[] { 2, 4, 6, 8, 10};
            numbers[0] = GetFirst();
        }


    }
}
