using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathMagician
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] numberChoices = ["even", "odd", "natural", "prime", "fibonacci"];

            // Ask the user how they feel
            Console.WriteLine("What kind of numbers should I print for you:");
            Console.WriteLine("Natural, Prime, Fibonacci, Even or Odd");

            // capture their response in a variable
            string command = Console.ReadLine();

            // Ask the user how many hours they slept last night
            Console.WriteLine("How many numbers do you want me to print?");
            Console.WriteLine("Listen: this console isn't very big, I can only print up to 30 numbers.");

            // capture their response in a variable
            string howMany = Console.ReadLine();

            if (numberChoices.Contains(command.ToLower()))
            {
            HowManyNumbersToPrint:
                // logic to determine how many numbers to print
                // if number is invalid
                    // write error and ...
                    goto HowManyNumbersToPrint;

                // if number is valid
                    // call the proper function for the type of number they want and ...
                    goto Finish;
            Finish:

                // write the result to the console
                Console.WriteLine($"You asked me to print { howMany } numbers that are { command }.  Here { listOfNumbers }");

                // prgram will quit when ...
                Console.WriteLine("Press any key to quit.");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Try again, please write something I can understand")
            }
        }
    }
}
