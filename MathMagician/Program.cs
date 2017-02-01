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
            string[] numberChoices = new string[] { "even", "odd", "natural", "prime", "fibonacci" };
            string finalListOfNumbers = "";
        Start:
            // Ask the user what kind of number to print
            Console.WriteLine("What kind of numbers should I print for you:");
            Console.WriteLine("Options: Natural, Fibonacci, Even or Odd");

            // capture their response in a variable
            string command = Console.ReadLine();

            if (numberChoices.Contains(command.ToLower()))
            {
        HowManyNumbersToPrint:
            int numberToPrint;
            // Ask the user how many numbers of ^ type to print
            Console.WriteLine("How many numbers do you want me to print?");
            Console.WriteLine("Listen: this console isn't very big, I can only print up to 30 numbers.");

            // capture their response in a variable
            string howMany = Console.ReadLine();
            try
                {
                    numberToPrint = Convert.ToInt32(howMany);
                    if (numberToPrint >= 1 && numberToPrint <= 30)
                    {
                        int[] listOfNumbers;
                        switch (command)
                        {
                            case "integer":
                                NaturalNumber naturalNumber = new NaturalNumber();
                                listOfNumbers = naturalNumber.GetSequence(numberToPrint);
                                finalListOfNumbers = naturalNumber.PrintNumbers(listOfNumbers);
                                break;
                            case "even":
                                EvenNumber evenNumber = new EvenNumber();
                                listOfNumbers = evenNumber.GetSequence(numberToPrint);
                                finalListOfNumbers = evenNumber.PrintNumbers(listOfNumbers);
                                break;
                            case "odd":
                                OddNumber oddNumber = new OddNumber();
                                listOfNumbers = oddNumber.GetSequence(numberToPrint);
                                finalListOfNumbers = oddNumber.PrintNumbers(listOfNumbers);
                                break;
                            case "fibonacci":
                                FibonacciNumber fibonacciNumber = new FibonacciNumber();
                                listOfNumbers = fibonacciNumber.GetSequence(numberToPrint);
                                finalListOfNumbers = fibonacciNumber.PrintNumbers(listOfNumbers);
                                break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid option. Please enter a positive number up to 30; I can only do so much.");
                        goto HowManyNumbersToPrint;
                    }

                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid option.");
                    goto HowManyNumbersToPrint;
                }

                // write the result to the console
                Console.WriteLine($"You asked for { howMany } numbers.");
                Console.WriteLine($"{ command } #s: { finalListOfNumbers }");
                
                // program will quit when ...
                Console.WriteLine("Press q to QUIT or any other key to try again.");
                var input = Console.ReadKey();

                if (input.KeyChar != 113)
                {
                    goto Start;
                }
            }
            else
            {
                Console.WriteLine("Try again, please choose an option I suggested or I am not going to play this game with you.");
                goto Start;
            }
        }
    }
}