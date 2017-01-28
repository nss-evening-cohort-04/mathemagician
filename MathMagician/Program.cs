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
            Console.WriteLine("What would you like for me to do?");
            Console.WriteLine("Press 1 to print integers");
            Console.WriteLine("");// "How" you provide the user useful info is on you.
            // Think about, "How will the user pick a command?"
            // Is it better to modify the original question?  Make it more useful?

            string command = Console.ReadLine();
            int formattedCommand = Int32.Parse(command);
            // Once I have the command (whatever it looks like), how do I check if it's a valid command?
            // i.e. does it exist in an array?

            // When should you actually create an instance of your number class?  Now or later?
            Console.WriteLine("How many should I print?");
            string how_many = Console.ReadLine();
            int numVal = Int32.Parse(how_many);

            // When do I check if the "How Many" response is too big?
            // If they enter a number > 30, how do I respond AND exit the program?
            if (!(numVal > 30))
            {

                if (formattedCommand == 1)
                {
                    Console.WriteLine($"Cool, I'm going to print {numVal} natural integers.");

                    NaturalNumber naturalNumber = new NaturalNumber();

                    var sequenceToPrint = naturalNumber.GetSequence(numVal);

                    naturalNumber.PrintNumbers(sequenceToPrint);
                }
                if (formattedCommand == 2)
                {
                    Console.WriteLine($"Cool, I'm going to print {numVal} even integers.");
                    Console.WriteLine("Press anykey to exit...");
                    Console.ReadKey();
                }
                if (formattedCommand == 3)
                {
                    Console.WriteLine($"Cool, I'm going to print {numVal} odd integers.");
                    Console.WriteLine("Press anykey to exit...");
                    Console.ReadKey();
                }
                if (formattedCommand == 4)
                {
                    Console.WriteLine($"Cool, I'm going to print {numVal} Fibonacci numbers.");
                    Console.WriteLine("Press anykey to exit...");
                    Console.ReadKey();

                } else
                {
                    Console.WriteLine("Please choose from one of the above options.");
                    Console.WriteLine("Press anykey to exit...");
                    Console.ReadKey();
                }
            } else
            {
                Console.WriteLine("Enter a number less than 30.");
                Console.WriteLine("Press anykey to exit...");
                Console.ReadKey();
            }
        }
    }
}
