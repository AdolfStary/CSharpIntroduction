using System;

namespace _2A
{
    class Program
    {
        static void Main(string[] args)
        {

            string inputString;

            // Asks for input
            Console.Write("Enter a string to be converted into uppercase: ");
            inputString = Console.ReadLine();


            // Converts string into uppercase
            inputString = inputString.ToUpper();


            // Returns result and awaits action to exit program
            Console.WriteLine("Your input in Uppercase: " + inputString);
            Console.ReadKey();

        }
    }
}
