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

            string command = Console.ReadLine();

            Console.WriteLine("How many should I print?");

            string how_many = Console.ReadLine();

            Console.WriteLine($"Cool, I'm going to print {how_many} {command} numbers.");

            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();

        }
    }
}
