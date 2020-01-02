using System;

namespace FirstConsoleApp
{
    class Program {
        static void Main(string[] args) {
            Movie pulpFiction = new Movie("Pulp Fiction", "Quentin Tarantino", "R");
            Movie forrestGump = new Movie("Forrest Gump", "Roubert Zemeckis", "PG-13");


            Console.WriteLine(pulpFiction.Rating);
            Console.WriteLine(forrestGump.director);
            Console.ReadLine();
        }

    }
}