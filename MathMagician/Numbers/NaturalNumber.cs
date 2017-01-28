using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathMagician.Numbers
{
    public class NaturalNumber : Integer
    {
        private int First { get; set; }

        public NaturalNumber()
        {
            First = 1;
            // this.First = 1;
     
        }

        public virtual int GetFirst()
        {
            return First;
        }

        public virtual int GetNext(int current)
        {
            return current + 1;
        }

        public virtual int[] GetSequence(int how_many)
        {
            var numberArray = new int[how_many];
            for (int i = 0; i < how_many; i++)
            {
                numberArray[i] = (GetNext(i)); 
            }
            return numberArray;
        }

        public virtual string printNumbers(int[] how_many)
        {
            return String.Join(" ", how_many);
        }
    }
}
