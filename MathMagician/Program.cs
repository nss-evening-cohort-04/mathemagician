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
            Console.WriteLine("What would you like for me to retrieve?");
            Console.WriteLine("  1. Natural numbers" + Environment.NewLine + "  2. Even Numbers" + Environment.NewLine + "  3. Odd Numbers" + Environment.NewLine + "  4. Fibonacci Numbers" + Environment.NewLine + "  5. Prime Numbers"); //pick a number to start from menu options
            //has a valid command been entered?
            string command = Console.ReadLine();

            Console.WriteLine("How many should I print?");

            string howMany = Console.ReadLine();
            //has it been entered as less than 30?
            //if number is greater than 30 how do i exit program?
            Console.WriteLine($"Cool, I am going to print {howMany} {command} numbers.");

            //OK print some stuff!
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
