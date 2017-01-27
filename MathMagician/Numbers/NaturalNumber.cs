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
        private int FirstNumber { get; set; }

        private int CurrentNumber { get; set; }

        private int LastNumber { get; set; }

        public NaturalNumber()
        {
            FirstNumber = 1;
            CurrentNumber = 0;
            LastNumber = 0;
        }

        public int GetFirst()
        {
            return FirstNumber;
        }

        public int GetNext(int current)
        {
            current = current + 1;
            return current;
        }

        public int[] GetSequence(int howMany)
        {
            int[] sequenceArray = new int[howMany];
            int counter = 0;
            for (int i = 0; i < sequenceArray.Length;  i++)
            {
                int numberToPush = GetNext(counter + FirstNumber) - 1;
                sequenceArray[counter] = numberToPush;
                counter++;
            }
           PrintNumbers(sequenceArray);
            return null;
        }

        public string PrintNumbers(int [] sequenceArray)
        {
            foreach (int number in sequenceArray)
            {
                Console.WriteLine(number.ToString());
            }
            return null;
        }
    }
}
