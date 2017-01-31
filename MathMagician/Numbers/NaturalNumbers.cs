using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathMagician.Numbers
{
    public class NaturalNumbers : Integer
    {
        protected int First { get; set; }
        protected int Step { get; set; }

        public NaturalNumbers()
        {
            First = 1;
            Step = 1;
        }

        public int GetFirst()
        {
           return First;
        }

        virtual public int GetNext(int current)
        {
            return current + Step;
        }

        public int[] GetSequence(int how_many)
        {
            int[] numbers = new int[how_many];
            numbers[0] = GetFirst();

            for (int i = 1; i < numbers.Length; i++)
            {
                numbers[i] = GetNext(numbers[i-1]);
            }
            return numbers;
        }

        public string printNumbers(int[] number_array)
        {
            return String.Join(", ", number_array);
        }

        
    }
}
