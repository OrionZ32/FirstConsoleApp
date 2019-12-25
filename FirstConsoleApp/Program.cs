using System;

namespace FirstConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int cubedNumber = cube(3);
            Console.WriteLine(cubedNumber);

            int squaredNumber = square(4);
            Console.WriteLine(squaredNumber);

            Console.ReadLine();
        }

        static int cube(int num)
        {
            int result = num * num * num;
            return result;
        }

        static int square(int num)
        {
            int result = num * num;
            return result;
        }
       
    }
}