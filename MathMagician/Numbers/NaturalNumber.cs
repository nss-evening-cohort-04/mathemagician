using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathMagician.Numbers
{
    public class NaturalNumber : Integer
    {
        private int First { get; set; }

        private int Current { get; set; }

        private int Next { get; set; }

        private int HowMany { get; set; }

        public NaturalNumber()
        {
            First = 1;
            Current = 1;
        }

        public int GetFirst()
        {
            return First;
        }

        public int GetNext(int current)
        {
            int Next = current + 1;
            return Next;
        }

        public int[] GetSequence(int how_many)
        {
            List<int> NumbersToPrint = new List<int>();
            while (Current <= how_many)
            {
                NumbersToPrint.Add(Current);
                GetNext(Current);
                Current += 1;
            }
            return NumbersToPrint.ToArray();
        }

        public string PrintNumbers(int[] how_many)
        {
            string Print = "|";
            foreach(var number in how_many)
            {
                Print += number.ToString() + "|";
            }
            Console.WriteLine(Print);

            Console.WriteLine("Press anykey to exit...");

            Console.ReadKey();
            return Print;
        }
    }
}
