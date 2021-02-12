using System;

namespace P3_CoinToss
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1 = heads
            // 2 = tails
            Console.WriteLine("Heads or Tails?");
            string answer = Console.ReadLine();

            // ask the user for heads or tails

            Random rand = new Random();
            int randomNumber = rand.Next(1, 3);// generate a random number between 1 and 2
            Console.WriteLine(randomNumber);
            // generate random number (done above)

            if (randomNumber == 1);
            {
                Console.WriteLine("The answer is heads!");
            }
            else
            {
                Console.WriteLine("The answer is tails!");
            }
            string Heads = Convert.ToString(randomNumber);
            // convert either the user's answer to an int or our random number to a string


            //see if they guessed right with the newly converted value 
        }
    }
}
