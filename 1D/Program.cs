using System;

namespace _1D
{
    class Program
    {
        static void Main(string[] args)
        {

            int inputNumber, result = 0;
            string inputString = null;
            
            Console.Write("Enter an integer: ");

            // Keeps asking for 4 digit integer unless the correct input is received. Fails if the length is not 4 characters or if anything else than numbers is included in input
            do 
            {
                if (inputString != null) Console.Write("Wrong input, enter a 4 digit integer: ");
                inputString = Console.ReadLine();
            }
            while ((inputString.Length != 4) || (!int.TryParse(inputString, out inputNumber)));


            // Loop Divides the integer input by 10^i (1000, 100, 10, 1) to obtain each digit, while it obtains the digit, it adds the digit's value to the total result 
            // and overwrites the input value with leftover(modulo %) from the division - getting a number that would be leftover if we removed the digit we already counted into result.
            for (int i=3; i >= 0; i--)
            {
                result += Convert.ToInt16(Math.Floor(inputNumber / Math.Pow(10, i)));
                inputNumber = Convert.ToInt16(Math.Floor(inputNumber % Math.Pow(10, i)));
                Console.WriteLine(result + " " + inputNumber);
            }

            // Writes the result into console and awaits action to exit the program.
            Console.WriteLine("The sum of all the number's digits is: " +  result + "\nPress enter to exit the program...");
            Console.ReadKey();
            
        }
    }
}
