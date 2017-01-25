using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathMagician.Numbers
{
    public class NaturalNumber : Integer // "public" ='s any code outside the class can access this class
    {
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

        public string PrintNumbers(int[] how_many)
        {
            throw new NotImplementedException(); //the () in these examples are calling contstructors. Constructors are parts of classes
        }
    }
}
