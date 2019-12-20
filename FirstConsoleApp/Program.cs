using System;

namespace FirstConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string myCar = "My new Honda Civic is white with black rims.";

            Console.WriteLine(myCar.Substring(7, 5) );
            Console.WriteLine(myCar[3]);
            Console.WriteLine(myCar.Length);
            Console.WriteLine(myCar.ToUpper() );
            Console.WriteLine(myCar.ToLower() );

            Console.ReadLine();
        }
    }
}