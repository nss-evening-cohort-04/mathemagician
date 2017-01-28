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
            Console.WriteLine("");// "How" you provide the user useful info is on you.
            // Think about, "How will the user pick a command?"
            // Is it better to modify the original question?  Make it more useful?

            string command = Console.ReadLine();
            // Once I have the command (whatever it looks like), how do I check if it's a valid command?
            // i.e. does it exist in an array?

            // When should you actually create an instance of your number class?  Now or later?

            Console.WriteLine("How many should I print?");

            string how_many = Console.ReadLine();

            // When do I check if the "How Many" response is too big?
            // If they enter a number > 30, how do I respond AND exit the program?

            int numVal = Int32.Parse(how_many);

            if (!(numVal > 30))
            {
                Console.WriteLine($"Cool, I'm going to print {numVal} {command} numbers.");

                NaturalNumber naturalNumber = new NaturalNumber();

                var sequenceToPrint = naturalNumber.GetSequence(numVal);

                naturalNumber.PrintNumbers(sequenceToPrint);
            } else
            {
                Console.WriteLine("Enter a number less than 30.");
                Console.WriteLine("Press anykey to exit...");
                Console.ReadKey();
            }
        }
    }
}
