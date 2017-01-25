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
            Console.WriteLine(""); //how you provide the user useful info is on you
            //Think about, how the user will pick a command.
            //Is it better to modify the original question? make it more useful?

            string command = Console.ReadLine();
            //once I have the command, how do I check to see if it is a valid command?

            //when should you actually create an instance of your number class? now or later?
            Console.WriteLine("How many should I print?");
       
            string how_many = Console.ReadLine();

            // when do I check if the how many response is too big?
            //if they enter a number > 30, how do I respond and exit the program?

            Console.WriteLine($"Cool, I'm going to print {how_many} {command} numbers.");

            //okay! Print some stuff!

            Console.WriteLine("Press any key to exit.");

            Console.ReadKey();

        }
    }
}
