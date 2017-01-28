using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathMagician.Numbers
{
    public class NaturalNumber : Integer
    {
        // FYI EVENS & ODDS ARE ALSO NATURAL NUMBERS SO THEY CAN INHERIT FROM THIS
        public int First { get; set; }

        public NaturalNumber()
        {
            First = 1;
            //this.First=1;
            
        }
        
        public int GetFirst()
        {
            return First;
        }

        public int GetNext(int current)
        {
            return current + 1;
        }

        public int[] GetSequence(int howMany)
        {
            return howMany[];
        }

        public string printNumbers(int[] howMany)
        {
            throw new NotImplementedException();
        }
    }
}
