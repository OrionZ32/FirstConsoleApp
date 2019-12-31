using System;

namespace FirstConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string secretWord = "honda";
            string guess = "";

            while(guess != secretWord)
            {
                Console.Write("Try to guess the secret word: ");
                guess = Console.ReadLine();
            }

            Console.Write("You guessed the correct word!");

            Console.ReadLine();
        }
    }
}