using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathMagician.Numbers
{
    public class EvenNumber : Integer
    {
        //don't want them to access it outside of the class//
        private int FirstNumber { get; set; }

        private int CurrentNumber { get; set; }

        private int LastNumber { get; set; }

        public EvenNumber()
        {
            FirstNumber = 2;
        }

        public int GetFirst()
        {
            return FirstNumber;
        }

        public int GetNext(int current)
        {
            return current + 2;
        }

        public int[] GetSequence(int howMany)
        {
            int[] number_array = new int[howMany];
            number_array[0] = GetFirst();
            for (int i = 1; i < number_array.Length; i++)
            {
                number_array[i] = GetNext(number_array[i-1]);
            }
            return number_array;
        }

        public string PrintNumbers(int[] sequenceArray)
        {
            foreach (int number in sequenceArray)
            {
                Console.WriteLine(number.ToString());
            }
            return null;
        }
    }
}
