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
            Console.WriteLine(""); // "How" you provide the user useful info is on you.
            // Think about, "How will the user pick a command?"
            // Is it better to modify the original question?  Make it more useful or relevant?

            string command = Console.ReadLine();
            // Once I have the command (whatever it looks like), how do I check if it a valid command?


            // When should you actually create an instance of your number class?  Now or later?
            Console.WriteLine("How many should I print?");

            string how_many = Console.ReadLine();

            // When do I check if the "How Many" response is too big?
            //If they enter a number > 30, how do I respond AND exit the program?

            Console.WriteLine($"Cool, I'm going to print {how_many} {command} numbers.");

            // Okay!!! Print some stuff!!!

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
