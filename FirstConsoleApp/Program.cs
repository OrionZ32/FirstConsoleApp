using System;

namespace FirstConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            SayHello("Orion", 20);
            SayHello("Jrue", 24);
            SayHello("Kenny", 30);  
            Console.ReadLine();
        }

        static void SayHello(string name, int age)
        {           
            Console.WriteLine("Hello " + name + " you are " + age + " years old");
        }
    }
}