using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MathMagician.Numbers;


namespace MathMagician.Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What type of number would you like me to display?");
            Console.WriteLine("Press 1 for Natural Number");
            Console.WriteLine("Press 2 for Fibonacci Number");
            Console.WriteLine("Press 3 for Odd Number");
            Console.WriteLine("Press 4 for Even Number");

            string command = Console.ReadLine();  
            int commandReturned = Int32.Parse(command);

            //once I have the command, how do I check to see if it is a valid command?

            //when should you actually create an instance of your number class? now or later?
            Console.WriteLine("How many should I print?");

            string how_many = Console.ReadLine();
            int numberReturned = Int32.Parse(how_many);


            // when do I check if the how many response is too big?
            //if they enter a number > 30, how do I respond and exit the program?
            if (numberReturned > 30)
            {

                Console.WriteLine("Please select a number less than 30");

                Console.WriteLine("Press any key to exit.");

                Console.ReadKey();

                Environment.Exit(0);

                if (commandReturned == 1)
                {
                    Console.WriteLine($"Cool, I'm going to print {numberReturned} Integer natural numbers.");

                    NaturalNumber naturalNumber = new NaturalNumber();
                    var whatToPrint = naturalNumber.GetSequence(numberReturned);
                    naturalNumber.PrintNumbers(whatToPrint);

                    //okay! Print some stuff!
                    Console.WriteLine(naturalNumber.PrintNumbers(whatToPrint));
                }
                else if (commandReturned == 2)
                {
                    Console.WriteLine($"Cool, I'm going to print {numberReturned} Fibonacci numbers.");

                    FibonacciNumber fiboNumber = new FibonacciNumber();
                    var whatToPrint = fiboNumber.GetSequence(numberReturned);
                    fiboNumber.PrintNumbers(whatToPrint);

                    //okay! Print some stuff!
                    Console.WriteLine(fiboNumber.PrintNumbers(whatToPrint));
                }
                else if (commandReturned == 3)
                {
                    Console.WriteLine($"Cool, I'm going to print {numberReturned} odd numbers.");

                    OddNumber oddNumber = new OddNumber();
                    var whatToPrint = oddNumber.GetSequence(numberReturned);
                    oddNumber.PrintNumbers(whatToPrint);

                    //okay! Print some stuff!
                    Console.WriteLine(oddNumber.PrintNumbers(whatToPrint));
                }
                else if (commandReturned == 4)
                {
                    Console.WriteLine($"Cool, I'm going to print {numberReturned} even numbers.");

                    EvenNumber evenNumber = new EvenNumber();
                    var whatToPrint = evenNumber.GetSequence(numberReturned);
                    evenNumber.PrintNumbers(whatToPrint);

                    //okay! Print some stuff!
                    Console.WriteLine(evenNumber.PrintNumbers(whatToPrint));
                }
            }



            Console.WriteLine("Press any key to exit.");

            Console.ReadKey();

        }

    }
}
