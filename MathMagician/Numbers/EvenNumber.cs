using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathMagician.Numbers
{
    public class EvenNumber : NaturalNumber
    {
        public override int First { get; set; }
        public EvenNumber()
        {
            First = 2;
        }

        public override int GetFirst()
        {
            return First;
        }

        public override int GetNext(int current)
        {
            //'current' is readonly so it can't be modified
            return current + 2;
        }

        public override int[] GetSequence(int howMany)
        {
            int[] numbers = new int[howMany];
            numbers[0] = GetFirst();

            for (int i = 2; i < numbers.Length; i++)
            {
                numbers[i] = GetNext(numbers[i - 2]);
            }

            return numbers;
        }
    }
}
