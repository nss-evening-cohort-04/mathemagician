using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathMagician.Numbers
{ 
    public class EvenNumber : Integer
    {
        private int EvenFirst { get; set; } // this is an example of a property
        private int Evencurrent { get; set; } // this is an example of a property

        public EvenNumber() //example of a constructor
        {
            EvenFirst = 2; //this calls the setter
        }
        public int GetFirst()
        {
            return EvenFirst;
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
