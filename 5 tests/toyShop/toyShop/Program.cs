using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace toyShop
{
    class Program
    {
        static void Main(string[] args)
        {
            double price_of_puzzle = 2.60;
            double price_of_talking_doll = 3;
            double price_of_teddy_bear = 4.10;
            double price_of_minion = 8.20;
            double price_of_truck = 2;

            double price_of_excursion = double.Parse(Console.ReadLine());
            int puzzles = int.Parse(Console.ReadLine());
            int talking_dolls = int.Parse(Console.ReadLine());
            int teddy_bears = int.Parse(Console.ReadLine());
            int minions = int.Parse(Console.ReadLine());
            int trucks = int.Parse(Console.ReadLine());

            double profit = puzzles * price_of_puzzle + talking_dolls * price_of_talking_doll + teddy_bears * price_of_teddy_bear + minions * price_of_minion + trucks * price_of_truck;

            if (profit >= 50)
            {
                profit = profit * 0.75;
            }

            profit = profit * 0.9;

            if (price_of_excursion <= profit)
            {
                // Console.WriteLine("Yes! " + (profit - price_of_excursion) + " lv left.");
                Console.Write("Yes! ");
                Console.Write("{0:f2}", (profit - price_of_excursion));
                Console.WriteLine(" lv left.");
            }
            else
            {
                Console.Write("Not enough money! ");
                Console.Write("{0:f2}", (price_of_excursion - profit));  
                Console.WriteLine(" lv needed.");
            }
        }
    }
}
