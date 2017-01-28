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
            Console.WriteLine("What type of numbers would you like me to print?");
            Console.WriteLine("Integer");
            Console.WriteLine("Even");
            Console.WriteLine("Odd");
            Console.WriteLine("Prime");
            Console.WriteLine("Fibonacci");

            // "How" you provide the user useful info is on you.
            // Think about, "How will the user pick a command?"
            // Is it better to modify the original question?  Make it more useful or relevant?

            string command = Console.ReadLine();
            // Once I have the command (whatever it looks like), how do I check if it a valid command?


            // When should you actually create an instance of your number class?  Now or later?
            Console.WriteLine("How many should I print?");

            string how_many = Console.ReadLine();

            // When do I check if the "How Many" response is too big?
            //If they enter a number > 30, how do I respond AND exit the program?
            int howMany = Int32.Parse(how_many);
            string commandLower = command.ToLower();

            // Okay!!! Print some stuff!!!

            if (howMany <= 30)
            {
                

                if (commandLower == "integer")
                {
                    Console.WriteLine($"Cool, I'm going to print {how_many} {command} numbers.");
                    NaturalNumber naturalNumber = new NaturalNumber();
                    Console.WriteLine(naturalNumber.printNumbers(naturalNumber.GetSequence(howMany)));
                }
                else if (commandLower == "even")
                {
                    Console.WriteLine($"Cool, I'm going to print {how_many} {command} numbers.");
                    EvenNumber evenNumber = new EvenNumber();
                    Console.WriteLine(evenNumber.printNumbers(evenNumber.GetSequence(howMany)));
                }
                else
                {
                    Console.WriteLine("Please select a number type from the list provided.");
                }
            } else
            {
                Console.WriteLine("Please input a number less than or equal to 30.");
            }
            
          

           

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
