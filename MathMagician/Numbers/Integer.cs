using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathMagician.Numbers
{
    interface Integer
    {
        int GetFirst(); //first number in sequence of numbers that's printed to screen
        int GetNext(int current); // given a current number, find way to calculate the next number
        int[] GetSequence(int howMany); // get how many numbers you want printed out and prints an array
        string PrintNumbers(int[] howMany); // print the above
    }
}
