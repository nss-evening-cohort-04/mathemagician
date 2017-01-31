using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathMagician.Numbers
{
    public class NaturalNumber : Integer
    {
        protected int First { get; set; }
        protected int Step { get; set; }

        public NaturalNumber()
        {
            First = 1;
            // this.First = 1;
            Step = 1;
     
        }

        public virtual int GetFirst()
        {
            return First;
        }

        public virtual int GetNext(int current)
        {
            return current + Step;
        }

        public virtual int[] GetSequence(int how_many)
        {
            var numberArray = new int[how_many];
            numberArray[0] = GetFirst();
            for (int i = 1; i < numberArray.Length; i++)
            {
                numberArray[i] = (GetNext(numberArray[i-1])); 
            }
            return numberArray;
        }

        public virtual string printNumbers(int[] how_many)
        {
            return String.Join(" ", how_many);
        }
    }
}
