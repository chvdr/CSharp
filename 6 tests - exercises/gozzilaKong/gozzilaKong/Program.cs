using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace gozzilaKong
{
    class Program
    {
        static void Main(string[] args)
        {
            // input 
            // Ред 1. Бюджет за филма – реално число в интервала [1.00 … 1000000.00]
            // Ред 2. Брой на статистите – цяло число в интервала [1 … 500]
            // Ред 3. Цена за облекло на един статист – реално число в интервала [1.00 … 1000.00]

            double totalBudget = double.Parse(Console.ReadLine());
            int statists = int.Parse(Console.ReadLine());
            double prcDress = double.Parse(Console.ReadLine());

            // Декорът за филма е на стойност 10% от бюджета.
            // При повече от 150 статиста, има отстъпка за облеклото на стойност 10%.

            double decorBudget = totalBudget * 0.1;
            if (statists > 150)
            {
                prcDress = prcDress * 0.9;
            }

            double totalCosts = decorBudget + prcDress * statists;

            if (totalCosts <= totalBudget)
            {
                Console.WriteLine("Action!");
                Console.Write("Wingard starts filming with ");
                Console.Write("{0:f2}", (totalBudget - totalCosts));
                Console.WriteLine(" leva left.");
            }
            else
            {
                Console.WriteLine("Not enough money!");
                Console.Write("Wingard needs ");
                Console.Write("{0:f2}", (totalCosts - totalBudget));
                Console.WriteLine(" leva more.");
            }
        }
    }
}
