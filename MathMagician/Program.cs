using MathMagician.Numbers;
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
            Console.WriteLine("What would you like for me to do?");
            
            string[] options = new string[] { "integer", "even", "odd", "fibonacci", "prime" };

            Console.WriteLine("Select from the following: Integer, Even, Odd, Fibonacci, or Prime");
            string command = Console.ReadLine().ToLower(); //once i have the command, how do I check if it's valid?

            //when should you create an instance of your number class? now or later?
            Console.WriteLine("How many should I print?");
            string howMany = Console.ReadLine();
            int numValHowMany = Int32.Parse(howMany);

            //when do i check if the "how many" response is too big? 
            // if they enter a number > 30, how do I respond AND exit the program?
            Console.WriteLine($"Cool, I'm going to print {howMany} {command} numbers." );

            if (command == "integer")
            {
                NaturalNumber naturalNumber = new NaturalNumber();
                var NatSequence = naturalNumber.GetSequence(numValHowMany);
                for (var i = 0; i < NatSequence.Length; i++)
                {
                    Console.WriteLine(NatSequence[i]);
                }
            }
            else if (command == "even")
            {
                EvenNumber evenNumber = new EvenNumber();
                var EvenSequence = evenNumber.GetSequence(numValHowMany);
                for (var i = 0; i < EvenSequence.Length; i++)
                {
                    Console.WriteLine(EvenSequence[i]);
                }

            }
            else if (command == "odd")
            {
                OddNumber oddNumber = new OddNumber();
                var OddSequence = oddNumber.GetSequence(numValHowMany);
                for (var i = 0; i < OddSequence.Length; i++)
                {
                    Console.WriteLine(OddSequence[i]);
                }

            }
            else if (command == "fibonacci")
            {
                FibonacciNumber fiboNumber = new FibonacciNumber();
                var FibonacciSequence = fiboNumber.GetSequence(numValHowMany);
                for (var i = 0; i < FibonacciSequence.Length; i++)
                {
                    Console.WriteLine(FibonacciSequence[i]);
                }

            }
            else { Console.WriteLine("> "); }


            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
