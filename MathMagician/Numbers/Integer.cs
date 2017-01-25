using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathMagician.Numbers
{
    interface Integer //this explains the interface and the methods it has
    {
        int GetFirst(); //first number in the sequence of numbers to be printed to screen
        int GetNext(int current); //given the current number, go to the next number
        int[] GetSequence(int how_many);//should give you an array of #'s
        string printNumbers(int[] how_many);//takes an array of #'s and gives a string
    }
}
