using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _11fruitShop
{
    class Program
    {
        static void Main(string[] args)
        {
            // variables: day, fruit and q. order is fruit-day-q

            string fruit = Console.ReadLine();
            bool fruitValid = ((fruit == "banana") || (fruit == "apple") || (fruit == "orange") || (fruit == "grapefruit") || (fruit == "kiwi") || (fruit == "pineapple") || (fruit == "grapes"));

            string day = Console.ReadLine();
            bool dayValid = ((day == "Monday") || (day == "Tuesday") || (day == "Wednesday") || (day == "Thursday") || (day == "Friday") || (day == "Saturday") || (day == "Sunday"));
            bool workDay = ((day == "Monday") || (day == "Tuesday") || (day == "Wednesday") || (day == "Thursday") || (day == "Friday"));

            double q = double.Parse(Console.ReadLine());

            // MAIN CODE

            double price = 0;

            if (!(dayValid && fruitValid))
            {
                Console.WriteLine("error");
            }
            else
            {
                // double q = double.Parse(Console.ReadLine()); I would leave the initialization here in most cases, but here the task is different (needs it on top)
                if (workDay)
                {
                    switch (fruit)
                    {
                        case "banana": price = 2.50; break;
                        case "apple": price = 1.20; break;
                        case "orange": price = 0.85; break;
                        case "grapefruit": price = 1.45; break;
                        case "kiwi": price = 2.70; break;
                        case "pineapple": price = 5.50; break;
                        case "grapes": price = 3.85; break;
                    }
                }
                else 
                {
                    switch (fruit)
                    {
                        case "banana": price = 2.70; break;
                        case "apple": price = 1.25; break;
                        case "orange": price = 0.90; break;
                        case "grapefruit": price = 1.60; break;
                        case "kiwi": price = 3.00; break;
                        case "pineapple": price = 5.60; break;
                        case "grapes": price = 4.20; break;
                    }
                } // if (workDay)

                Console.WriteLine("{0:f2}", (price * q));

            } // if (!(dayValid && fruitValid))
        }
    }
}
