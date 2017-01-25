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
            Console.WriteLine("Select from the following: Integer, Even Numbers, Odd Numbers, Fibonacci Numbers, or Prime Numbers");
            string command = Console.ReadLine(); //once i have the command, how do I check if it's valid?

            //when should you create an instance of your number class? now or later?
            Console.WriteLine("How many should I print?");
            string howMany = Console.ReadLine();

            //when do i check if the "how many" response is too big? 
            // if they enter a number > 30, how do I respond AND exit the program?
            Console.WriteLine($"Cool, I'm going to print {howMany} {command} numbers." );

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
