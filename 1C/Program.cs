using System;

namespace _1C
{
    class Program
    {
        static void Main(string[] args)
        {
            string ageAsString = null;
            int age, result;

            // Asks for age and checks for correct input, also calls input incorrect if person claims they're older than 150. If input is incorrect it prompts user to enter age again.
            Console.Write("Please enter your age: ");

            do 
            {
                if (ageAsString != null) Console.Write("Wrong input, please enter your age: ");
                ageAsString = Console.ReadLine();
            }
            while (!int.TryParse(ageAsString, out age) || age > 150);

            // Calculates Birthyear and shows it in the console, awaits action to exit the program.
            result = 2020 - age;
            Console.Write("So you were born in " + result + " eh? \nPress enter to exit the program...");
            Console.ReadKey();

        }
    }
}
