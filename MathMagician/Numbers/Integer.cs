using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathMagician.Numbers
{
    interface Integer
    {
        int GetFirst();// first number in sequence printed to screen
        int GetNext(int current);// given current num, find a way to calculate next number
        int[] GetSequence(int how_many);// takes how many items to print, into an array
        string printNumbers(int[] how_many);// takes int array, prints string
    }
}
