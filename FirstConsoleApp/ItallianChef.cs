using System;
using System.Collections.Generic;
using System.Text;

namespace FirstConsoleApp {
    class ItallianChef : Chef {

        public void MakeAlfredo() {
            Console.WriteLine("The Itallian Chef makes alfredo");
        }

        public override void MakeChicken() {
            Console.WriteLine("The Itallian Chef makes chicken alfredo");
        }
    }
}
