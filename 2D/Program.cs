using System;

namespace _2D
{
    class Program
    {
        static void Main(string[] args)
        {

            double sideA, sideB, sideC, result;
            string inputString = null;

            // Asks for first side, keeps repeating unless number is entered
            Console.Write("Enter length of the first side of triangle: ");
            do
            {
                if (inputString != null) Console.Write("Wrong input, enter length of the first side of triangle: ");
                inputString = Console.ReadLine();
            }
            while (!double.TryParse(inputString, out sideA));

            // Reset for my indicatior to alter message when asking for input
            inputString = null;


            // Asks for second side, repeats unless number is entered
            Console.Write("Enter length of the second side of triangle: ");
            do
            {
                if (inputString != null) Console.Write("Wrong input, enter length of the second side of triangle: ");
                inputString = Console.ReadLine();
            }
            while (!double.TryParse(inputString, out sideB));

            // Pythagoras calculation
            result = Math.Sqrt((Math.Pow(sideA, 2) + Math.Pow(sideB, 2)));
            sideC = Math.Round(result, 2);


            // Outputs result, asks for action to exit program
            Console.Write("The third side of triangle is: " + sideC + " \nPress enter to exit the program...");
            Console.ReadKey();
        }
    }
}
