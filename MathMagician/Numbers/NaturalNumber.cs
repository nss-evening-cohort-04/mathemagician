using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathMagician.Numbers
{
    public class NaturalNumber : Integer
    {
        protected int First { get; set; }
        protected int Step { get; set; }
        //private List<int> Sequence { get;  set;} - my original solution

        public NaturalNumber()
        {
            First = 1;
            Step = 1;
            //this.First = 1;
            //List<int> Sequence = new List<int>(); - my original solution
        }
        
        public int GetFirst()
        {
            return First;
        }

        virtual public int GetNext(int current)
        {
            return current + Step;
        }

        public int[] GetSequence(int how_many)
        {
            //Sequence = new List<int>();

            //for (int i = First; i <= how_many; i++)
            //{
            //Sequence.Add(i);
            //}

            //return Sequence.ToArray();
            int[] numbers = new int[how_many];
            numbers[0] = GetFirst(); // i = 1
            for (int i = 1; i < numbers.Length; i++)
            {
                numbers[i] = GetNext(numbers[i - 1]);
            }

            return numbers;
        }

        public string PrintNumbers(int[] number_array)
        {
            return String.Join(" ", number_array);
        }
    }
}
