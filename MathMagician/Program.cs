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

            /*if (command.Contains("integer"))
            {
                NaturalNumber.GetSequence(numValHowMany);
                NaturalNumber.PrintNumbers(numValHowMany);
            }*/


            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
