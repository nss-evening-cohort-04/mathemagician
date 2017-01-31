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
   
        static void Main(string[] number_array)
        {
            Console.WriteLine("What would you like for me to do?");
            Console.WriteLine("I can print the following number types: natural, even, odd, or fibonacci."); //user enters choice.
            Console.Write(">");
            //Prompt for user

            string command = Console.ReadLine().ToLower(); //converts string to lowercase to prevent casing errors during user input

           
            Console.WriteLine("How many should I print?");
            Console.Write(">");
            //Another prompt
            int how_many = Convert.ToInt32(Console.ReadLine());
            //converts input to an int
            if (how_many <= 0 || how_many > 30) //evaluates if input is between 1 and 30
            {
                Console.WriteLine("I'm sorry, I can only print between 1 and 30 numbers. Please reopen to try again."); //Displays message to user
                System.Threading.Thread.Sleep(3000); //Delays application close so the user can see message.
                Environment.Exit(0); //Exits application.
            }


            Console.WriteLine($"Cool, I'm going to print {how_many} {command} numbers.");
            //Okay, print some stuff. 

            if (command == "natural")
            {
                Console.WriteLine();        
            }
            else if (command == "even")
            {
                Console.WriteLine();
            }
            else if (command == "odd")
            {
                Console.WriteLine();
            }
            else if (command == "fibonacci")
            {
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("I'm sorry, that is not a number type I understand. Please reopen to try again."); //Prints invalid command message to user.
                System.Threading.Thread.Sleep(3000);//Delays application close by 3 seconds so user can see message.
                Environment.Exit(0); //Exits the application
            }

            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }
    }
}
