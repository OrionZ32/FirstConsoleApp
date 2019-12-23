using System;

namespace FirstConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] luckyNumbers = { 2, 7, 9, 16, 23, 34 };
            
            string[] cars = new string[3];
            cars[0] = "Honda Civic";
            cars[1] = "Nissan 370z";
            cars[2] = "Dodge Challenger";


            Console.WriteLine( luckyNumbers[1] );
            Console.WriteLine(cars[0]);

            Console.ReadLine();
        }
    }
}