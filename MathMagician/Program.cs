using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathMagician.Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What type of number would you like me to display? Integers, Primes, Fibbonaci, Odd or Even?");

            string command = Console.ReadLine();
            //once I have the command, how do I check to see if it is a valid command?

            //when should you actually create an instance of your number class? now or later?
            Console.WriteLine("How many should I print?");

            string how_many = Console.ReadLine();

            // when do I check if the how many response is too big?
            //if they enter a number > 30, how do I respond and exit the program?

            Console.WriteLine($"Cool, I'm going to print {how_many} {command} numbers.");

            //okay! Print some stuff!
            //string [] number_array = Console.WriteLine( { number_array } );


            Console.WriteLine("Press any key to exit.");

            Console.ReadKey();

        }
    }
}
