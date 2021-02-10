using System;

namespace P3_CoinToss
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int randomNumber = rand.Next(1, 3);// generate a random number between 1 and 2

            Console.WriteLine(randomNumber);

        }
    }
}
