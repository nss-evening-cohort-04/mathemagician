using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathMagician.Numbers
{
    public class EvenNumber : NaturalNumber
    {

        public EvenNumber()
        {
            First = 2;
            Step = 2;
        }

        //public override int GetFirst()
        //{
        //    return First;
        //}

       //public override int GetNext(int current)
       // {
       //     return current += 2;
       // }

        //public int[] GetSequence(int how_many)
        //{
        //    int[] numbers = new int[how_many];
        //    numbers[0] = GetFirst(); // i = 2
        //    for (int i = 1; i < numbers.Length; i++)
        //    {
        //        numbers[i] = GetNext(numbers[i - 1]);
        //    }

        //    return numbers;
        //}

        //public string PrintNumbers(int[] number_array)
        //{
        //    return String.Join(" ", number_array);
        //}
    }
}
