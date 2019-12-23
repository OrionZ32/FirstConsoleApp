using System;

namespace FirstConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine( Math.Abs(-23) );
            Console.WriteLine( Math.Sqrt(36) );
            Console.WriteLine( Math.Pow(4, 2) );
            Console.WriteLine( Math.Max(81, 60) );
            Console.WriteLine( Math.Min(32, 53) );
            Console.WriteLine( Math.Round(5.74) );

            Console.ReadLine();
        }
    }
}