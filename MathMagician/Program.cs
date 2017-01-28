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
            string[] numberChoices = new string[] { "even", "odd", "natural", "prime", "fibonacci" };

            // Ask the user what kind of number to print
            Console.WriteLine("What kind of numbers should I print for you:");
            Console.WriteLine("Options: Natural, Prime, Fibonacci, Even or Odd");

            // capture their response in a variable
            string command = Console.ReadLine();

            // Ask the user how many numbers of ^ type to print
            Console.WriteLine("How many numbers do you want me to print?");
            Console.WriteLine("Listen: this console isn't very big, I can only print up to 30 numbers.");

            // capture their response in a variable
            string howMany = Console.ReadLine();

// code not finished from here down 1/28 @1:47pm

            if (numberChoices.Contains(command.ToLower()))
            {
            HowManyNumbersToPrint:
                // logic to determine how many numbers to print
                // if number is invalid
                // write error and ...
                goto HowManyNumbersToPrint;

                // if number is valid
                // call the proper function for the type of number they want and ...
                // int[] values = Enumerable.Range(start, end - start).ToArray();
                string listOfNumbers = "";
                goto Finish;
            Finish:

                // write the result to the console
                Console.WriteLine($"You asked me to print { howMany } numbers that are { command }.  Here { listOfNumbers }");

                // program will quit when ...
                Console.WriteLine("Press any key to quit.");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Try again, please write something I can understand");
            }
        }
    }
}
