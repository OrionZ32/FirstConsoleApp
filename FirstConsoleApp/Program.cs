using System;

namespace FirstConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student("Jrue", "Computer Science", 3.2);
            Student student2 = new Student("May", "Engineering", 3.8);

            Console.WriteLine(student1.HasHonors());
            Console.WriteLine(student2.HasHonors());

            Console.ReadLine();
        }

    }
}