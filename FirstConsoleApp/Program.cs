using System;

namespace FirstConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isMale = false;
            bool isTall = false;

            // && = both have to be true, || = only one has to be true
            if (isMale && isTall)
            {
                Console.WriteLine("You are a tall male");
            } else if (isMale && !isTall) 
            {
                Console.WriteLine("You are a short male");
            } else if (!isMale && isTall) 
            {
                Console.WriteLine("You are not male but you wear mens size 13 nikes");            
            } else 
            {
                Console.WriteLine("You are not male or tall");
            }

            Console.ReadLine();
        }
       
    }
}