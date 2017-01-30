using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathMagician.Numbers
{
    public class NaturalNumber : Integer
    {
        //don't want them to access it outside of the class//
        protected int FirstNumber { get; set; }

        protected int Step { get; set; }

        private int CurrentNumber { get; set; }

        public NaturalNumber()
        {
            FirstNumber = 1;
            Step = 1;
        }

        public int GetFirst()
        {
            return FirstNumber;
        }

        virtual public int GetNext(int current)
        {
            return current += Step;
        }

        virtual public int[] GetSequence(int howMany)
        {
            int[] numbers = new int[howMany];
            numbers[0] = GetFirst();
            for (int i = 1; i < numbers.Length; i++)
            {
                numbers[i] = GetNext(numbers[i-1]);

            }
            return numbers;
        }

        public string PrintNumbers(int [] number_array)
        {
            return string.Join(" ", number_array);
        }
    }
}
