using System;

namespace MathMagician.Numbers
{
    public class FibonacciNumber : NaturalNumber
    {
        private int[] BaseSequence { get; set; }

        public FibonacciNumber()
        {
            BaseSequence = new int[] { 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377, 610, 987, 1597, 2584, 4181, 6765, 10946, 17711, 28657, 46368, 75025, 121393, 196418, 317811, 514229, 832040 };
        }

        public override int GetNext(int current)
        {
            return BaseSequence[Array.LastIndexOf(BaseSequence,current) + 1];
        }

        public override int[] GetSequence(int how_many)
        {
            int[] numbers = new int[how_many];
            numbers[0] = GetFirst();
            numbers[1] = GetFirst();

            for (int i = 2; i < how_many; i++)
            {
                numbers[i] = GetNext(numbers[i-1]);
            }
            return numbers;
        }


    }
}
