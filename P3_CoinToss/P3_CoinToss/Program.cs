﻿using System;

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

            Random rand = new Random();
            int randomNumber = rand.Next(1, 3);// generate a random number between 1 and 2
            int guess = 0;
            int coin = 0;
            
            Console.WriteLine(randomNumber);

            if(answer == "heads")
            {
                guess = 1;
            }
            else if (answer == "tails") 
            {
                guess = 2;
            }
            if (randomNumber == 1)
            {
                coin = 1;
                Console.WriteLine("The answer is heads!");
            }
            else if ( randomNumber == 2)
            {
                coin = 2;
                Console.WriteLine("The answer is tails!");
            }
            if (guess == coin)
            {
                Console.WriteLine("You've guessed correctly!");
            }
            else
            {
                Console.WriteLine("YOu've guessed incorrectly!");
            }
            string num = Convert.ToString(randomNumber);

        }
    }
}
