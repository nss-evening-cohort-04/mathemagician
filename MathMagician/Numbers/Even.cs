using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathMagician.Numbers
{
    public class Even : Integer
    {
        private int First { get; set; }

        public Even()
        {
            First = 2;
        }

        public int GetFirst()
        {
            return First;
        }

        public int GetNext(int current)
        {
            return current + 2;
        }

        public int[] GetSequence(int how_many)
        {
            int[] evens = new int[how_many];
            evens[0] = GetFirst();
            for (int i = 1; i < evens.Length; i++)
            {
                evens[i] = GetNext(evens[i - 1]);
            }

            return evens;
        }

        public string PrintNumbers(int[] even_array)
        {
            return String.Join(" ", even_array);
        }
    }
}
