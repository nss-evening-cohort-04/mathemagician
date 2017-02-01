using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathMagician.Numbers
{
    public class Fibonacci : NaturalNumber
    {
        private int[] BaseSequence { get; set; }

        public Fibonacci()
        {
            First = 1;
            //Step = ;
        }

        public override int GetNext(int current)
        {
            int counter = 1;
            int next = 1;
            while (next <= current)
            {
                counter++;
                next = getFibonacciAtPlace(counter);
            }

            return next;
        }

        private int getFibonacciAtPlace(int place) //Googled it - in class code-along
        {
            if (place == 0)
            {
                return 1;
            }
            if (place <= 1)
            {
                return place;
            }
            return getFibonacciAtPlace(place - 1) + getFibonacciAtPlace(place - 2);
        }

        public override int[] GetSequence(int how_many)
        {
            BaseSequence = new int[how_many];
            for (var i = 0; i < how_many; i++)
            {
                BaseSequence[i] = getFibonacciAtPlace(i);
            }

            return BaseSequence;
        }

    }  
}
