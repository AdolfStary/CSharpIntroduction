using System;

namespace _1A
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string inputAsString = null;
            int inputInt, result = 0;

            // Asks for number
            Console.Write("Hello! Input an integer to get it cubed: ");
            
            do 
            {
                // If given input is not an integer it will ask again
                if(inputAsString != null)
                {
                    Console.Write("Not an integer, please enter an integer: ");
                }

                // Saves input as string first
                inputAsString = Console.ReadLine();

            }
            // Tries to Parse the string into Int, if it fails, repeats the cycle
            while (!Int32.TryParse(inputAsString, out inputInt)) ;

            // Cubes the input
            result = Convert.ToInt32(Math.Pow(inputInt, 3));

            // Gives the solution to user and waits for input to close the program.
            Console.WriteLine(inputInt + " cubed is " + result + ". Press enter to close the program...") ;
            Console.ReadKey();

        }


        
    }
}
