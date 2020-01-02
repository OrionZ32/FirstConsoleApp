using System;

namespace FirstConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new Book("Fahrenheit 451", "Ray Bradbury", 158);
            Book book2 = new Book("The Giver", "Lois Lowry", 240);
            Book book3 = new Book();

            Console.WriteLine(book1.title);
            Console.WriteLine(book1.author);
            Console.WriteLine(book1.pages);
            
            Console.ReadLine();
        }

    }
}