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
        private int CurrentNumber { get; set; }

        public NaturalNumber()
        {
            First = 1;
            // this.First = 1;
     
        }

        public int GetFirst()
        {
            return First;
        }

        public int GetNext(int current)
        {
            int Next = current + 1;
            return Next;
        }

        public int[] GetSequence(int how_many)
        {
            var numberArray = new int[how_many];
            for (int i = 0; i < how_many; i++)
            {
                numberArray[i] = (GetNext(i)); 
            }
            return numberArray;
        }

        public string printNumbers(int[] how_many)
        {
            string numberString = String.Join(", ", how_many);
            return numberString;
        }
    }
}
