using MathMagician.Numbers;
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
            Console.WriteLine("What would you like for me to print?");
            Console.WriteLine("Commands:\r\nIntegers\r\nPrimes\r\nFibonacci\r\nEven\r\nOdd");
            //"How" you provide the user with useful info is on you.
            //Think about, "How will the user pick a command?"
            //Is it better to modify the original question? Make it more useful?

            string command = Console.ReadLine().ToLower();
            //Once I have the command(whatever it looks like), how do I check if it's a valid command?
            switch (command)
            {
                case "integers":
                    NaturalNumber natural = new NaturalNumber();
                    Console.WriteLine("How many should I print ?");
                    int how_many = int.Parse(Console.ReadLine());
                    if(how_many > 30)
                    {
                        Console.WriteLine($"Oh yeah, keep the number less than or equal to 30...");
                        Console.ReadKey();
                    }
                    Console.WriteLine($"Cool, I'm going to print {how_many} {command} numbers.");
                    int[] toPrint = natural.GetSequence(how_many);
                    Console.WriteLine(natural.PrintNumbers(toPrint));
                    Console.WriteLine("press any key to exit...");
                    Console.ReadKey();
                    break;

                case "primes":
                    Console.WriteLine($"Still working on");
                    Console.ReadKey();
                    break;

                case "fibonacci":
                    Console.WriteLine($"Still working on");
                    Console.ReadKey();
                    break;

                case "even":
                    Console.WriteLine($"Still working on");
                    Console.ReadKey();
                    break;

                case "odd":
                    Console.WriteLine($"Still working on");
                    Console.ReadKey();
                    break;

                default:
                    Console.WriteLine("Whoops! that not a listed command");
                    Console.ReadKey();
                    break;

            }

            //When should you actually create an instance of you number class? now or later?
            //Console.WriteLine("How many should I print ?");

            //string how_many = Console.ReadLine();

            //When do I check if the "How Many" response is more than 30?
            //If they enter a number > 30, how do I respond AND exit the program?

            //Console.WriteLine($"Cool, I'm going to print {how_many} {command} numbers.");

            //Okay!!! pring some stuff!!!
            
        }
    }
}
