using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathMagician.Numbers
{
    public class NaturalNumber : Integer // "public" ='s any code outside the class can access this class
    {
        private int First { get; set; } // this is an example of a property
        private int current { get; set; } // this is an example of a property


        public NaturalNumber() //example of a constructor
        {
            First = 1; //this calls the setter
        }

        public int GetFirst()
        {
            return First;
            //this.First = 1; --> 'this' means the current class instance
            //the above is the exact same as  return First
        }

        public int GetNext(int current)
        {
            //'current' argument is read-only
            //given the current number, go to the next number

            return current + 1;
        }

        public int[] GetSequence(int how_many)
        {
            //ex: even sqc {2,4,6,8,10} -- get a sqc to run here

            int[] numbers = new int[how_many]; //this is allocating space bc arrays are set once they are made
            numbers[0] = GetFirst(); // i = 1 --> using this to get the first number
            for (int i = 1; i < numbers.Length; i++)
            {
                numbers[i] = GetNext(numbers[i - 1]);

            }
            return numbers;
        }

        public string PrintNumbers(int[] number_array)
        {
            return String.Join(" ", number_array);
        }
    }
}
