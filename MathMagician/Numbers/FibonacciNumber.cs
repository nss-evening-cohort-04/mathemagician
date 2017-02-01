using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathMagician.Numbers
{
    public class FibonacciNumber : NaturalNumber
    {
        private int[] BaseSequence { get; set; }

        public FibonacciNumber()
        {
            First = 1;
            //Step = ;
            BaseSequence = new int[] { 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55 }; // can i add to BaseSequence if it's an array? 


        }


        public override int GetNext(int current)
        {
            int counter = 1;
            int next = 1;
            while (next <= current)
            {
                counter++;
                next = getFiboAtPlace(counter);
            }
            return next;
        }

        private int getFiboAtPlace(int place)
        {
            if (place == 0)
            {
                return 1;
            }
            if (place <= 1)
            {
                return place;
            }
            return getFiboAtPlace(place - 1) + getFiboAtPlace(place - 2); // this is recursion, calling the method in on itself
        }

        public override int[] GetSequence(int howMany)
        {
            //setting new BaseSequence
            BaseSequence = new int[howMany];
            for (var i = 0; i < howMany; i++)
            {
                BaseSequence[i] = getFiboAtPlace(i);
            }
            return BaseSequence;
        }
    }


    
}
