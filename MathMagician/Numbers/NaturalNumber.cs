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
            int addone = current + 1;
            return addone; 
        }

        // I am defining the sequence as NaturalNumbers from
        // 0 up to the number the user entered
        public int[] GetSequence(int howMany)
        {
            throw new NotImplementedException();
        }

        public string PrintNumbers(int[] howMany)
        {
            throw new NotImplementedException();
        }

        int Integer.GetSequence(int how_many)
        {
            throw new NotImplementedException();
        }

        public string printNumbers(int[] how_many)
        {
            throw new NotImplementedException();
        }
    }
}