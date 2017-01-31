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
            /************************************ INPUT VALIDATION ************************************/

            // Prompt the user to choose number type
            Console.WriteLine("What would you like for me to do?");
            Console.WriteLine("Press 1 to print natural numbers");
            Console.WriteLine("Press 2 to print even numbers");
            Console.WriteLine("Press 3 to print odd numbers");
            Console.WriteLine("Press 4 to print Fibonacci numbers");
            Console.WriteLine("");

            // Ensure user's response is a number 1-4
            int[] possibleNumberChoices = { 1, 2, 3, 4 };
            int formattedUserNumberChoice;
            string userNumberChoice = Console.ReadLine();
            bool boolUserChoseAValidNumberOption = false;
            bool boolUserEnteredANumber = Int32.TryParse(userNumberChoice, out formattedUserNumberChoice);
            if (!boolUserEnteredANumber)
            {
                Console.WriteLine("Please select from the above options.");
                Console.WriteLine("Press any key to exit...");
                Console.ReadKey();
                Environment.Exit(0);
            }

            for (var i = 0; i < possibleNumberChoices.Length; i++)
            {
                if (formattedUserNumberChoice == possibleNumberChoices[i])
                {
                    boolUserChoseAValidNumberOption = true;
                }
            }

            if (!boolUserChoseAValidNumberOption)
            {
                Console.WriteLine("Enter a number between 1 and 4.");
                Console.WriteLine("Press any key to exit...");
                Console.ReadKey();
                Environment.Exit(0);
            }

            // Prompt the user to enter how many numbers to print
            Console.WriteLine("How many should I print?");

            // Ensure the user entered a valid number to print
            string how_many = Console.ReadLine();
            int numVal;
            bool boolUserEnteredAValidNumberToPrint = false;
            bool bool_how_many = Int32.TryParse(how_many, out numVal);
            if (!bool_how_many)
            {
                Console.WriteLine("Please enter a number between 1 and 30.");
                Console.WriteLine("Press any key to exit...");
                Console.ReadKey();
                Environment.Exit(0);
            }
            if (!(numVal < 1 || numVal > 30))
            {
                boolUserEnteredAValidNumberToPrint = true;
            }

            if (!boolUserEnteredAValidNumberToPrint)
            {
                Console.WriteLine("Please enter a number between 1 and 30.");
                Console.WriteLine("Press any key to exit...");
                Console.ReadKey();
                Environment.Exit(0);
            }

            /************************************ PRINT, PER USER CHOICE ************************************/

            if (formattedUserNumberChoice == 1)
            {
                Console.WriteLine($"Cool, I'm going to print {numVal} natural integers.");

                NaturalNumber naturalNumber = new NaturalNumber();
                var sequenceToPrint = naturalNumber.GetSequence(numVal);
                Console.WriteLine(naturalNumber.PrintNumbers(sequenceToPrint));

                Console.WriteLine("Press any key to exit...");
                Console.ReadKey();
            }
            else if (formattedUserNumberChoice == 2)
            {
                Console.WriteLine($"Cool, I'm going to print {numVal} even integers.");

                EvenNumber evenNumber = new EvenNumber();
                var sequenceToPrint = evenNumber.GetSequence(numVal);
                Console.WriteLine(evenNumber.PrintNumbers(sequenceToPrint));

                Console.WriteLine("Press any key to exit...");
                Console.ReadKey();
            }
            else if (formattedUserNumberChoice == 3)
            {
                Console.WriteLine($"Cool, I'm going to print {numVal} odd integers.");

                OddNumber oddNumber = new OddNumber();
                var sequenceToPrint = oddNumber.GetSequence(numVal);
                Console.WriteLine(oddNumber.PrintNumbers(sequenceToPrint));

                Console.WriteLine("Press any key to exit...");
                Console.ReadKey();
            }
            else if (formattedUserNumberChoice == 4)
            {
                Console.WriteLine($"Cool, I'm going to print {numVal} Fibonacci numbers.");

                FibonacciNumber fibonacciNumber = new FibonacciNumber();
                var sequenceToPrint = fibonacciNumber.GetSequence(numVal);
                Console.WriteLine(fibonacciNumber.PrintNumbers(sequenceToPrint));

                Console.WriteLine("Press any key to exit...");
                Console.ReadKey();
            }
        }
    }
}
