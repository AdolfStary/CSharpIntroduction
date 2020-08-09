using System;

namespace _2E
{
    class Program
    {
        static void Main(string[] args)
        {
            string randomPassword = null;
            char character;
            Random randomCharacter = new Random();

            // Generates 5 random characters and appends them to the randomPassword string
            for(int i = 0; i < 5; i++)
            {
                character = (char)randomCharacter.Next(65, 90);
                randomPassword += character;
            }


            // Calls out the result and asks for action to exit the program.
            Console.WriteLine("Your new random password is: " + randomPassword);
            Console.ReadKey();


        }
    }
}
