using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathMagician.Numbers
{
    public class EvenNumber : NaturalNumber
    {
        private int First { get; set; }

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
            int Next = current + 2;
            return Next;

        }

        public override int[] GetSequence(int how_many)
        {
          
            var numberArray = new int[how_many];
            for (int i = 1; i <= how_many; i++)
            {
               
                numberArray[i-1] = i*2;
            }
            return numberArray;
        }
    }
}
