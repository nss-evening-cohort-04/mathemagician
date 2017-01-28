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
            //this.First = 2;
        }
        public int GetFirst()
        {
            return 2;
        }

        public int GetNext(int current)
        {
            throw new NotImplementedException();
        }

        public int[] GetSequence(int how_many)
        {
            throw new NotImplementedException();
        }

        public string printNumbers(int[] how_many)
        {
            throw new NotImplementedException();
        }
    }
}
