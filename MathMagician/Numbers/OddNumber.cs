using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathMagician.Numbers
{
    public class OddNumber : NaturalNumber
    {
        public override int GetNext(int current)
        {
            return current + 2;
        }

        public override int[] GetSequence(int how_many)
        {
            var numberArray = new int[how_many];
            numberArray[0] = GetFirst();
            for (int i = 1; i < how_many; i++)
            {

                numberArray[i] = (i * 2) + 1;
            }
            return numberArray;
        }
    }
}
