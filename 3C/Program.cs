using System;

namespace _3C
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputNumber = null;
            string query;
            int number;
            double masterNumber;

            // Asks for a number input until correct input is entered
            do 
            {

                if (inputNumber != null)    Console.Write("Wrong input: ");
                Console.Write("Type a number to find out whether it is a perfect square of a whole number: ");
                inputNumber = Console.ReadLine();

            }
            while (!int.TryParse(inputNumber, out number));

            // Gets square root of input
            masterNumber = Math.Sqrt(number);

            // Decides whether input is perfect square of whole number
            if (masterNumber % Math.Round(masterNumber, 0) == 0) query = "Number entered is a perfect square of number " + masterNumber;
            else query = "Sorry, number entered is not a perfect square of a whole number.";


            // Calls out result and waits for action to close the program
            Console.Write(query + "\nPress enter to exit the program...");
            Console.ReadKey();
            
        }
    }
}
