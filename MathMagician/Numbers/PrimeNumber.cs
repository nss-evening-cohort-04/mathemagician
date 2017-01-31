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
            bool IsNotPrime = true;

            while(IsNotPrime)
            {
                for (int i = 2; i <= current; i++)
                {
                    if(next % i == 0)
                    {
                        i++;
                        IsNotPrime = true;
                        break;
                    }

                    IsNotPrime = false;
                }
            }

            return next;
        }
    }
}
