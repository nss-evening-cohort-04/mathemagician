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
            Console.WriteLine("Command choices: Natural, Prime, Fibonacci, Even or Odd.");
            Console.WriteLine("Pick a command: "); //How you provide the user useful info is on you.
            //think about, 'How will the user pick a command?'
            //Is it better to modify the original question? Make it more useful?

            string command = Console.ReadLine();
            //Once I have the command (whatever it looks like), how do I chekc if 
            //it's a valid command?

            //When should you actually create an instance of your number class? now or later?

            Console.WriteLine("How many should I print?");

            string howMany = Console.ReadLine();



            //When do I check if the "HowMany" response is too big? no more than 30
            //If they inter a number > 30, how do I respond and exit the program?

            Console.WriteLine($"Cool, I'm going to print {howMany} {command} numbers.");

            //okay!! Print some stuff!
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
