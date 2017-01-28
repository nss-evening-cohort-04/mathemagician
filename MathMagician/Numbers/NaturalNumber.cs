using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathMagician.Numbers
{
    public class NaturalNumber : Integer
    {
        // FYI EVENS & ODDS ARE ALSO NATURAL NUMBERS SO THEY CAN INHERIT FROM THIS
        public int First { get; set; }

        public NaturalNumber()
        {
            First = 1;
            //this.First=1;
            
        }
        
        public int GetFirst()
        {
            return First;
        }

        public int GetNext(int current)
        {
            //'current' is readonly so it can't be modified
            return current + 1;
        }

        public int[] GetSequence(int howMany)
        {
            int[] numbers = new int[howMany];
            numbers[0] = GetFirst();

            for(int i = 1; i < numbers.Length; i++)
            {
                numbers[i] = GetNext(numbers[i - 1]);
            }

            return numbers;
            
        }

        public string PrintNumbers(int[] numberArray)
        {
            return string.Join(" ", numberArray);
        }
    }
}
