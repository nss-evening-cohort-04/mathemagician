using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathMagician.Numbers
{
    public class NaturalNumbers : Integer
    {
        private int First { get; set; }

        public NaturalNumbers()
        {
            First = 1;
            //this.First = 1;
        }

        public int GetFirst()
        {
           return 1;
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
