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
            Console.WriteLine(""); //"How" you provide the user useful info is your choice TomBO (you could have them enter a number or enter specific text)
                                   //Think about, 'How will the user pick a command?'
                                   // Is it better to modify the original question? Make it more useful?

            Console.WriteLine("1.Add this later" + Environment.NewLine);

            string commandz = Console.ReadLine(); //this is "reading" what the user types in
            // saying string commandz is saving 
            //the type 'string' as commandz
            //but how do we know this a valid command?

            Console.WriteLine("How many should I print?");

            string how_many = Console.ReadLine();//this is "reading" what the user types in

            //When do I check if the "How many" response is too big?
            //If they enter a number > 30, how do I respond AND exit the program?

            Console.WriteLine($"Cool, I'm going to print {how_many} {commandz} numbers.");

            //Okay!!! Print some stuff!!

            Console.WriteLine("Press any key to exit..");
            Console.ReadKey();
        }
    }
}
