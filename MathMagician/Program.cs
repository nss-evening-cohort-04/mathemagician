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
            // Ask the user how they feel
            Console.WriteLine("In five words or less, tell me how you are feeling today ...");
            // capture their response in a variable
            string feeling = Console.ReadLine();

            // Ask the user how many hours they slept last night
            Console.WriteLine("How many hours did you sleep last night?");
            // capture their response in a variable
            string timeSlept = Console.ReadLine();

            // write the result to the console
            Console.WriteLine($"You got { timeSlept } hours of sleep last night and that makes you feel like { feeling }.");

            // prgram will quit when ...
            Console.WriteLine("Press any key to quit and get some more rest to face another day");
            Console.ReadKey();


        }
    }
}
