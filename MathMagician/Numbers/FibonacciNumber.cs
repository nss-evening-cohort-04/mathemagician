using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathMagician.Numbers
{
    public class FibonacciNumber: NaturalNumber
    {
        //count hold 1,1,2,3,5,8,...
        private int[] BaseSequence { get; set; }

        public FibonacciNumber ()
        {
            FirstNumber = 0;
        }

        public override int[] GetSequence(int howMany)
        {
            int numberToPush;
            int[] numbers = new int[howMany];
            numbers[0] = 0;
            numbers[1] = 1;
            for (int i = 2; i < numbers.Length; i++)
            {
                numberToPush = numbers[i-2] + numbers[i-1];
                numbers[i] = numberToPush;

            }
            return numbers;
        }
    }
}
