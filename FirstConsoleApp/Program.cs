using System;

namespace FirstConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] luckyNumbers = { 3, 7, 11, 17, 34 };
            
            for(int i = 0; i < luckyNumbers.Length; i++)
            {
                Console.WriteLine(luckyNumbers[i]);
            }       
            
            for(int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i);
            }

            Console.ReadLine();
        }
    }
}