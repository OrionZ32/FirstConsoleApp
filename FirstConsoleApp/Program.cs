using System;

namespace FirstConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new Book();
            book1.title = "Fahrenheit 451";
            book1.authour = "Ray Bradbury";
            book1.pages = 158;

            Book book2 = new Book();
            book2.title = "The Giver";
            book2.authour = "Lois Lowry";
            book2.pages = 240;

            Console.WriteLine(book1.title);
            Console.WriteLine(book1.authour);
            Console.WriteLine(book1.pages);
            Console.WriteLine();
            Console.WriteLine(book2.title);
            Console.WriteLine(book2.authour);
            Console.WriteLine(book2.pages);

            Console.ReadLine();
        }

    }
}