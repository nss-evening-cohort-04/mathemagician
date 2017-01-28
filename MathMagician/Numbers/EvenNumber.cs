using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace MathMagician.Numbers
{
    public class EvenNumber : Integer
    {

        public int First { get; set; }

        public EvenNumber()
        {
            First = 2;
        }

        public int GetFirst()
        {
            return First;
        }

        public int GetNext(int current)
        {
            //'current' argument is read only

            return current + 2;
        }

        public int[] GetSequence(int how_many)
        {
            int[] numbers = new int[how_many];

            numbers[0] = GetFirst();

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
