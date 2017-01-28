using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MathMagician.Numbers;

namespace MathMagician
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What would you like for me to retrieve?");
            Console.WriteLine("  1 - Natural numbers" + Environment.NewLine + "  2 - Even Numbers" + Environment.NewLine + "  3 - Odd Numbers" + Environment.NewLine + "  4 - Fibonacci Numbers" + Environment.NewLine + "  5 - Prime Numbers"); //pick a number to start from menu options
            int command = Convert.ToInt32(Console.ReadLine());
            string typeSelected;
            if (new[] { 1, 2, 3, 4, 5 }.Contains(command))
            {
                Console.WriteLine("How many should I print?");
            }
            else
            {
                Environment.Exit(0);
            }
            int howMany = Convert.ToInt32(Console.ReadLine());
            if (howMany <= 30)
            {
                if (command == 1)
                {
                    typeSelected = "natural";
                    Console.WriteLine($"Cool, I am going to print {howMany} {typeSelected} numbers.");
                    NaturalNumber naturalNumber = new NaturalNumber();
                    int [] arrayToPrint = naturalNumber.GetSequence(howMany);
                    Console.WriteLine(naturalNumber.PrintNumbers(arrayToPrint));
                }
                else if (command == 2)
                {
                    typeSelected = "even";
                    Console.WriteLine($"Cool, I am going to print {howMany} {typeSelected} numbers.");
                    EvenNumber evenNumber = new EvenNumber();
                    int[] arrayToPrint = evenNumber.GetSequence(howMany);
                    Console.WriteLine(evenNumber.PrintNumbers(arrayToPrint));
                }
                else if (command == 3)
                {
                    typeSelected = "odd";
                }
                else if (command == 4)
                {
                    typeSelected = "fibonacci";
                }
                else
                {
                    typeSelected = "prime";
                }
            }
            else
            {
                Environment.Exit(0);
            }
            //OK print some stuff!
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
