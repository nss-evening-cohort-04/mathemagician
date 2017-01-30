using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathMagician.Numbers
{
    public class NaturalNumber : Integer
    {
        
        private int First { get; set; }
        
        public NaturalNumber()
        {
            First = 1;
            // this.First = 1;
        }

        public int GetFirst()
        {
            return First;
        }

        // next number in a sequence
        // IE pass 1 return 2
        public int GetNext(int current)
        {
            int addOne = current + 1;
            return addOne;
        }

        // I am defining the sequence as NaturalNumbers from
        // 0 up to the number the user entered
        public int[] GetSequence(int howMany)
        {
            int[] result = new int[howMany];
            result[0] = GetFirst();
            for(var i = 1; i < howMany; i++)
            {
                result[i] = GetNext(result[i - 1]);
            }
 
            return result;
        }

        public string PrintNumbers(int[] howMany)
        {
            return String.Join(" ", howMany);
        }

    }
}
