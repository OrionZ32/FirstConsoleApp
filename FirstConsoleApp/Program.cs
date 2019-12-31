using System;

namespace FirstConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string secretWord = "honda";
            string guess = "";
            int guessCount = 0;
            int guessLimit = 3;
            bool outOfGuesses = false;

            while(guess != secretWord && !outOfGuesses)
            {
                if (guessCount < guessLimit)
                {
                    Console.Write("Try to guess the secret word (HINT: Japanese car manufacture) : ");
                    guess = Console.ReadLine();
                    guessCount++;
                } else
                {
                    outOfGuesses = true;               
                }
            }
            if(outOfGuesses)
            {
                Console.Write("You are out of guesses");
            } else
            {
                Console.Write("You guessed the correct word!");
            }
            

            Console.ReadLine();
        }
    }
}