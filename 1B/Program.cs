using System;

namespace _1B
{
    class Program
    {
        static void Main(string[] args)
        {
            string amountString = null, guestString = null;
            double theAmount, result = 0;
            int numberOfGuest = 0;


            // Asks for input of the bill amount and checks for correct input, if input is wrong, it prompts user again.
            Console.Write("Enter the amount on your receipt: ");
            
            do 
            {
                if (amountString != null) Console.Write("Input is incorrect, please enter the amount on your bill: ");
               amountString = Console.ReadLine();
            }
            while (!Double.TryParse(amountString, out theAmount));


            // Asks for input of the amount of guest and checks for correct input, if input is wrong, it prompts user again.
            Console.Write("Enter the number of guests: ");

            do 
            {
                if (guestString != null) Console.Write("Input is incorrect, please enter the amount on your bill: ");
               guestString = Console.ReadLine();
            }
            while (!int.TryParse(guestString, out numberOfGuest));


            // Calculates everyone's share and rounds it to 2 decimal spaces.
            result = Math.Round(theAmount / numberOfGuest, 2);

            // Prints result, awaits action to exit
            Console.WriteLine("Everyone's equal share is: $" + result +" \nPress enter to exit the program...");
            Console.ReadKey();

        }
    }
}
