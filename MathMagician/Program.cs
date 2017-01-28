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
            Console.WriteLine();//How you provide the user useful info is on you.
            //Think about how the user will pick a command?
            //It is better to modify the original question? Make it more useful?
            
            string command = Console.ReadLine();
            //Once i have the command(whatever it looks like), how do i check if
            //It's a valid command?

            Console.WriteLine("How many should I print ?");

            string how_many = Console.ReadLine();
            //when do i check if the "How Many" response is too big? check that it is no more than 30
            //If they enter a number > 30, how do i respond and exit the program?

            Console.WriteLine("Cool, I'm going to print {how many} {command} numbers. ");
            //okay!!! Print some stuff!
            Console.WriteLine("Press any key to exit . . . .");
            Console.ReadKey();
        }
    }
}
