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
            //User enters a command, then presses enter
            Console.WriteLine("What would you like me to do?");
            Console.WriteLine("");// *"How" will you provide the user with useful info?
            // *Think about, "how will the user pick a command? Is it better to modify the original quesiton? 

            string command = Console.ReadLine();
            // *once I have the command, hwo do I check if it's a valid command?

            //*When should you actually create an instance of your class? now or later?

            //User enters how many numbers should be printed.
            Console.WriteLine("How many should I print?");

            string how_many = Console.ReadLine();
            // *When do I check if the "How Many" response is too big?
            // *if they enter a number > 30, how do I resond and exit the program?

            //Then prints the the requested list of numbers space separated on the following line.
            Console.WriteLine($"Cool, I'm going to print {how_many} {command}. ok?");

            Console.WriteLine("Press any key to exit - have a great day!");
            Console.ReadKey();
        }
    }
}
