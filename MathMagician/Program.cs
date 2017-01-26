using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MathMagician.Numbers;

namespace MathMagician
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What would you like me to Do?");
            Console.WriteLine("Hint: \"natural\" for natural numbers;");
            Console.WriteLine(); // "How" you provide the user useful info is on you.
            // Think about, 'How will teh user pick a command?'
            // Is it better to modify the original question? Make it more useful?
            string command = Console.ReadLine();
            // Once I have the command (whatever it looks like), how do I check if
            // it's a valid command?
            if( command.ToLower() == "natural")
            {
                NaturalNumber naturalNumber = new NaturalNumber();

                // when should you actually create an instance of your number class? now or later?
                Console.WriteLine("How many should I print?");
                string how_many = Console.ReadLine();
                // when do I check if the "How Many" response it too big?
                // If they enter a number > 30, how do I respond AND exit the program?
                int totalNum = Int32.Parse(how_many);
                if(totalNum <= 30 && totalNum >=1)
                {
                    Console.WriteLine($"Cool, I'm going to print {how_many} {command} numbers.");
                    // Okay!!! Print some stuff!!!
                    string actualResult = naturalNumber.PrintNumbers(naturalNumber.GetSequence(totalNum));
                    Console.WriteLine(actualResult);
                }
                else
                {
                    Console.WriteLine("Sorry, the number is out of range!");

                }
            }
            else
            {
                Console.WriteLine("Sorry, wrong command!");
            }
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }
    }
}
