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

        public NaturalNumber()
        {
            First = 1;
            // same as this.First = 1;

        }

        public int GetFirst()
        {
            return First;
        }

        public int GetNext(int current)
        {
            return current += 1;
        }

        public int[] GetSequence(int how_many)
        {
            //create an Array or List
            List<int> sequenceList = new List<int>();
            //start with GetFirst 
            //Array.push(NaturalNumber.GetFirst());
            sequenceList.Add(GetFirst());

            //initialize current int to GetFirst number
            int current = GetFirst();
            //int current = NaturalNumber.GetFirst();

            //iterate according to how_many
            for (var i = 0; i < how_many; i++)
            {
                //Get the next number in the sequence by calling the class method GetNext
                int Next = GetNext(current);
                //Array.push(NaturalNumber.GetNext(int current));
                sequenceList.Add(Next);
                //assign previous number to current int variable
                //current = 
                current = Next;
            }

            int[] printArray = sequenceList.ToArray();

            return printArray;
        }

        public string PrintNumbers(int[] ToPrint)
        {
            StringBuilder sb = new StringBuilder("Here Ya Go: ");

            foreach (int val in ToPrint)
            {
                sb.Append(val + ", ");
            }

            string RemoveLastComma = sb.ToString();
            int lastCommaIndex = RemoveLastComma.LastIndexOf(",");
            string toRemove = ", ";
            string PrintString = RemoveLastComma.Remove(lastCommaIndex, toRemove.Length);

            return PrintString;
            //or
            //return String.Join(" ", number_array);
        }
    }
}

