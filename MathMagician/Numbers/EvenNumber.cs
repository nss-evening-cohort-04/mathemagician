using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathMagician.Numbers
{
    public class EvenNumber : Integer
    {
        private int First { get; set; }

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
            return current + 2;
        }

        public int[] GetSequence(int how_many)
        {
            throw new NotImplementedException();
        }

        public string PrintNumbers(int[] how_many)
        {
            throw new NotImplementedException();
        }
    }
}
