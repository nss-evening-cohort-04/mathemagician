using MathMagician.Numbers;
using System;
using System.Linq;

namespace MathMagician
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] choices = new string[] { "integer", "even", "odd", "fibonacci", "prime" };
            string printNumbers = "";
            Start:
            Console.WriteLine("What type of numbers would you like?");
            Console.WriteLine("Integer, Even, Odd, Fibonacci, Prime");  // TODO: How to provide user with useful infomation on commmands
            // Think about, "How will the user pick a command?"
            // Is it better to modify the original question? Make it more useful?

            string command = Console.ReadLine();
            // Once I have the command (whatever it looks like), how do I check if
            // it's valid command?

            if (choices.Contains(command.ToLower()))
            {
            // When should you actually create an instance of you number class? now or later?
            HowMany:
                int numValHowMany;
                Console.WriteLine("How many should I print?");

                string how_many = Console.ReadLine();

                // When do I check if the "How many" response is too big?
                // If they enter a number > 30, how do I respond AND exit the program?
                try
                {
                    numValHowMany = Convert.ToInt32(how_many);
                    if(numValHowMany > 0)
                    {
                        if (numValHowMany < 31)
                        {
                            int[] sequence;
                            switch (command)
                            {
                                case "integer":
                                    NaturalNumber naturalNumber = new NaturalNumber();
                                    sequence = naturalNumber.GetSequence(numValHowMany);
                                    printNumbers = naturalNumber.PrintNumbers(sequence);
                                    break;
                                case "even":
                                    EvenNumber evenNumber = new EvenNumber();
                                    sequence = evenNumber.GetSequence(numValHowMany);
                                    printNumbers = evenNumber.PrintNumbers(sequence);
                                    break;
                                case "odd":
                                    OddNumber oddNumber = new OddNumber();
                                    sequence = oddNumber.GetSequence(numValHowMany);
                                    printNumbers = oddNumber.PrintNumbers(sequence);
                                    break;
                                case "prime":
                                    PrimeNumber primeNumber = new PrimeNumber();
                                    sequence = primeNumber.GetSequence(numValHowMany);
                                    printNumbers = primeNumber.PrintNumbers(sequence);
                                    break;
                                case "fibonacci":
                                    FibonacciNumber fibonacciNumber = new FibonacciNumber();
                                    sequence = fibonacciNumber.GetSequence(numValHowMany);
                                    printNumbers = fibonacciNumber.PrintNumbers(sequence);
                                    break;
                            }

                        }
                        else
                        {
                            Console.WriteLine("Please enter a positive number up to 30.");
                            goto HowMany;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Please enter a positive number up to 30.");
                        goto HowMany;
                    }
                   
                }
                catch (FormatException e)
                {
                    Console.WriteLine(e.Message);
                    goto HowMany;
                }

                Console.WriteLine($"Cool, I'm going to print {how_many} {command} numbers.");

                Console.WriteLine(printNumbers);

                Console.WriteLine("Press any key to exit...");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Invalid command entered");
                goto Start;
            }
        }
    }
}
