using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathMagician.Numbers
{
    public class FibonacciNumber : NaturalNumber
    {
        private int BaseSequence { get; set; }

        public FibonacciNumber()
        {
            First = 1;
            //Step = FiboSequence();
            
        }


        //public override int[] GetSequence(int howMany)
        //{
        //    int[] fiboOutput = new int[howMany];
        //    fiboOutput[0] = GetFirst();

        //    int a = 1;
        //    int b = 1;

        //    for (int i = 1; i < fiboOutput.Length; i++)
        //    {
        //        fiboOutput[i] = GetNext(fiboOutput[i - 1]);
        //        int temporary = a;
        //        a = b;
        //        b = temporary + b;

        //        fiboOutput.ToArray(b);
        //    }

        //    return fiboOutput;
        //}


    
    }


    
}
