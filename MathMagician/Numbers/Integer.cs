namespace MathMagician.Numbers
{
    interface Integer
    {
        int GetFirst();
        int GetNext(int current);
        int[] GetSequence(int how_many);
        string PrintNumbers(int[] how_many);
    }
}
