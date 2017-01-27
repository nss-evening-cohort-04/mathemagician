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
        private int[] Sequence { get;  set;}

        public NaturalNumber()
        {
            First = 1;
            //this.First = 1;
        }
        
        public int GetFirst()
        {
            return First;
        }

        public int GetNext(int current)
        {
            return current + 1;
        }

        public int[] GetSequence(int how_many)
        {
            for ( int i = First; i < how_many; i++)
            {
                Sequence[i]
            }
        }

        public string PrintNumbers(int[] how_many)
        {
            throw new NotImplementedException();
        }
    }
}
