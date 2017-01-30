using System;

namespace MathMagician.Numbers
{
    public class NaturalNumber : Integer
    {
        protected int First { get; set; }
        protected int Step { get; set; }

        public NaturalNumber()
        {
            First = 1;
            Step = 1;
        }

        public virtual int GetFirst()
        {
            return First;
        }

        public virtual int GetNext(int current)
        {
            return current + Step;
        }

        public virtual int[] GetSequence(int how_many)
        {
            int[] numbers = new int[how_many];
            numbers[0] = GetFirst();
            for (int x = 1; x < how_many; x++)
            {
                numbers[x] = GetNext(numbers[x-1]);
            }
            return numbers;
        }

        public string PrintNumbers(int[] how_many)
        {
            return String.Join(" ", how_many); ;
        }
    }
}
