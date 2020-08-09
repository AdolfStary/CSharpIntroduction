using System;

namespace _2C
{
    class Program
    {
        static void Main(string[] args)
        {

            string amountString = null;
            int amountPosts;
            int amountOfPaint;
            string bucket = " buckets ";

            // How many posts can one bucket paint
            int bucketVolume = 4;
            

            // Keeps asking for number input if input is wrong.
            do
            {
                if (amountString != null) Console.Write("Wrong input, please input a number. ");
                Console.Write("How many fence posts do we have to paint? : ");
                amountString = Console.ReadLine();
            }
            while (!int.TryParse(amountString, out amountPosts));

            // Calculates how many buckets we need
            amountOfPaint = amountPosts / bucketVolume;
            // If there is leftover after dividing number of posts by bucket's volue it will add one more bucket of paint to the total
            if (amountPosts % bucketVolume > 0) amountOfPaint++;
            // If we only need one bucket, it changes buckets into bucket, to make it bit more polished.
            if (amountOfPaint == 1) bucket = " bucket ";
            
            // Outputs result and prompts user to press enter to exit the program.
            Console.Write("We will need " + amountOfPaint + bucket + "of paint. \nPress enter to exit the program...");
            Console.ReadKey();

        }
    }
}
