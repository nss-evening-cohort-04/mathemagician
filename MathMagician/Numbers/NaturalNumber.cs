using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathMagician.Numbers //because it is inside the Numbers folder, the namespace has a .Numbers
{
    public class NaturalNumber : Integer //any code outside the class can access it and its items per "public"
    {
        // default/dynamic implementation - it's private so it won't use anything else besides Integer
        private int First { get; set; }

        // a constructor - must be public, no return type; matches the name of the class
        public NaturalNumber()
        {
            First = 1;
            // this.First = 1;  these are equal - "this" means the current class instance
        }

        public int GetFirst()
        {
            return First;
        }

        public int GetNext(int current)
        {
            
            throw new NotImplementedException();
        }

        public int[] GetSequence(int First)
        {
            while (First <= final_how_many)
            {
                First = First + 1;
            }
            throw new NotImplementedException();
        }

        public string PrintNumbers(int[] how_many)
        {
            var NaturalNumberList = Enumerable.Range(1, final_how_many).ToList;
            throw new NotImplementedException();
        }
    }
}
