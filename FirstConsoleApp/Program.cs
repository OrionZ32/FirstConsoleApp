using System;

namespace FirstConsoleApp
{
    class Program {
        static void Main(string[] args) {

            Chef chef = new Chef();
            chef.MakeChicken();

            ItallianChef itallianChef = new ItallianChef();
            itallianChef.MakeChicken();

            Console.ReadLine();
        }

    }
}