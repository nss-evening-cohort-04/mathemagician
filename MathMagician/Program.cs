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
        GETCOMMAND:
            Console.WriteLine("What would you like me to Do?");
            Console.WriteLine("Hint: Options are natural, odd, even, fibonacci, prime.");
            // "How" you provide the user useful info is on you.
            // Think about, 'How will teh user pick a command?'
            // Is it better to modify the original question? Make it more useful?
            string command = Console.ReadLine();
            // Once I have the command (whatever it looks like), how do I check if
            // it's a valid command?
            // when should you actually create an instance of your number class? now or later?
            NaturalNumber myNumber;
            switch (command.ToLower())
            {
                case "natural":
                    myNumber = new NaturalNumber();
                    break;
                case "odd":
                    myNumber = new Odd();
                    break;
                case "even":
                    myNumber = new Even();
                    break;
                case "fibonacci":
                    myNumber = new FibonacciNumber();
                    break;
                case "prime":
                    myNumber = new PrimeNumber();
                    break;
                default:
                    Console.WriteLine("Sorry, wrong command!");
                    goto GETCOMMAND;
            }

        GETNUM:
            Console.WriteLine("How many should I print? Range: 1 - 30");
            string how_many = Console.ReadLine();
            // when do I check if the "How Many" response it too big?
            // If they enter a number > 30, how do I respond AND exit the program?
            int totalNum = Int32.Parse(how_many);
            if (totalNum <= 30 && totalNum >= 1)
            {
                Console.WriteLine($"Cool, I'm going to print {how_many} {command} numbers.");
                // Okay!!! Print some stuff!!!
                string actualResult = myNumber.PrintNumbers(myNumber.GetSequence(totalNum));
                Console.WriteLine(actualResult);
            }
            else
            {
                Console.WriteLine("Sorry, the number is out of range!");
                goto GETNUM;

            }

            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }
    }
}
