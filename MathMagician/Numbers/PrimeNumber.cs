using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathMagician.Numbers
{
    public class PrimeNumber : NaturalNumber
    {
        public PrimeNumber()
        {
            First = 2;
        }

        public override int GetNext(int current)
        {
            int next = current + 1;
            bool IsNotFound = true;
          
            while(IsNotFound)
            {
                for (int i = 2; i < ((current > 5)?(next / 2) : 3); i++)
                {
                    if (next % i == 0)
                    {
                        next++;
                        IsNotFound = true;
                        break;
                    }
                    IsNotFound = false;
                }
            }
            return next;
        }

    }
}
