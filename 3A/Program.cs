using System;

namespace _3A
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int player1, player2, number;
            string inputNumber = null;


            // Asks for input of first player, keeps asking until number between 1-10 is input
            do
            {

                if (inputNumber != null) Console.Write("Wrong input, only integers 1-10 please. ");
                Console.Write("Player 1 - Guess the number (1-10): ");
                inputNumber = Console.ReadLine();
                
            }
            while (!int.TryParse(inputNumber, out player1) || ((player1 > 10) || (player1 < 1)));

            // Reset my fault indicator
            inputNumber = null;

             // Asks for input of second player, keeps asking until number between 1-10 is input
            do
            {

                if (inputNumber != null) Console.Write("Wrong input, only integers 1-10 please. ");
                Console.Write("Player 2 - Guess the number (1-10): ");
                inputNumber = Console.ReadLine();
                
            }
            while (!int.TryParse(inputNumber, out player2) || ((player2 > 10) || (player2 < 1)));

            // Randomizes a number between 1 - 10 and shows it in console
            number = random.Next(1, 10);
            Console.WriteLine("Random number is: " + number);

            // Gets absolute value of difference between random number and player's guess = How far off they were
            player1 = Math.Abs(player1 - number);
            player2 = Math.Abs(player2 - number);

            // Calls result into console based on value comparison.
            if (player1 == player2) Console.WriteLine("It's a tie.");
            else if (player1 < player2) Console.WriteLine("Player 1 was closer.");
            else Console.WriteLine("Player 2 was closer.");

            // Asks for action to exit program
            Console.Write("Press enter to exit the program...");
            Console.ReadKey();
            


        }
    }
}
