using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathMagician.Numbers
{
    public class NaturalNumber : Integer
    {
        private int first { get; set; }

        public NaturalNumber()
        {
            first = 1;
            // this.first = 1;
        }

        public virtual int GetFirst()
        {
            return first;
        }

        public virtual int GetNext(int current)
        {
            return current + 1;
        }

        public virtual int[] GetSequence(int how_many)
        {
            int[] numbers = new int[how_many];
            numbers[0] = GetFirst();
            for (int x = 1; x < how_many; x++)
            {
                numbers[x] = GetNext(numbers[x-1]);
            }
            return numbers;
        }

        public string PrintNumbers(int[] how_many)
        {
            return String.Join(" ", how_many); ;
        }
    }
}
