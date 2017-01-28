using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathMagician.Numbers
{
    public class FibonacciNumber : NaturalNumber
    {

        public override int GetNext(int current)
        {
            return current + 1;
        }

        public override int[] GetSequence(int how_many)
        {
            List<int> tmpList = new List<int>();

            int firstnumber = GetFirst(), secondnumber = GetNext(firstnumber), result = 0;

            tmpList.Add(firstnumber);
            tmpList.Add(firstnumber);
            tmpList.Add(secondnumber);
            for (int i = 2; i <= how_many; i++)
            {
                result = firstnumber + secondnumber;
                firstnumber = secondnumber;
                secondnumber = result;
                tmpList.Add(result);
            }

            return tmpList.ToArray();
        }
    }
}
