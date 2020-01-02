using System;
using System.Collections.Generic;
using System.Text;

namespace FirstConsoleApp {
    class Chef {

        public virtual void MakeChicken() {
            Console.WriteLine("The Chef makes chicken");
        }

        public void MakeSteak() {
            Console.WriteLine("The Chef makes steak");
        }

        public void MakeSalad() {
            Console.WriteLine("The Chef makes salad");
        }
    }
}
