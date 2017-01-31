using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathMagician.Numbers
{
    public class FibonacciNumber : NaturalNumber
    {
        // Could hold 1, 1, 2, 3, 5, 8, ...
        private int[] BaseSequence { get; set; }

        public override int GetNext(int current)
        {
            Double NextFibo = Math.Round(current * 1.61803399);
            int Next = Convert.ToInt32(NextFibo);
            return Next;
        }

        public override int[] GetSequence(int how_many)
        {
            var numberArray = new int[how_many];
            if (how_many == 1)
            {
                numberArray[0] = GetFirst();
                return numberArray;
            }
            else if (how_many == 2)
            {
                numberArray[0] = GetFirst();
                numberArray[1] = GetFirst();
                return numberArray;
            }
            else
            {
                numberArray[0] = GetFirst();
                numberArray[1] = GetFirst();
                numberArray[2] = GetFirst() + 1;
                for (int i = 3; i < numberArray.Length; i++)
                {
                    numberArray[i] = (GetNext(numberArray[i - 1]));
                }
                return numberArray;
            }
        }
    }

   
}
