using System;
using System.Linq;

namespace _2B
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] inputArray = {0, 0, 0};
            string inputNumber;
            string query;
            bool repeat = true;

            // Loop through the array to get inputs
            for (int i = 0; i < 3; i++)
            {
                // Asks for the initial input
                query = "Enter integer #" + (i+1) + ": ";
                Console.Write(query);

                // Reads input, tries to save it into array, if the input is not integer it loops into a repeat loop and gives an error message. Loop stops once integer is input
                do 
                {
                    if (repeat == false) Console.Write("Wrong input. " + query);
                    inputNumber = Console.ReadLine();
                    repeat = int.TryParse(inputNumber, out inputArray[i]);
                }
                while (!repeat);
                            
            }

            // Shows result
            Console.Write("The highest input number is " + inputArray.Max() + " and the lowest is " + inputArray.Min() + "\nPress enter to exit the program...");
            Console.ReadKey();
            
        }
    }
}
