using System;

namespace _3B
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;
            string inputString = null;
            string query;


            // Keeps asking for number unless correct input is received.
            do
            {

                if (inputString != null) Console.Write("Wrong input. ");
                Console.Write("Type an integer to find out whether its odd or even: ");
                inputString = Console.ReadLine();
        
            }
            while (!int.TryParse(inputString, out number));


            // Decides whether number is odd or even using modulo operand.
            if (number % 2 > 0) query = "Number " + number + " is odd.";
            else query = "Number " + number + " is even.";

            // Returns result and asks for action to close the program.
            Console.Write(query + "\nPress enter to exit the program...");
            Console.ReadKey();

        }       
    }
}
