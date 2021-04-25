using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace skiTrip
{
    class Program
    {
        static void Main(string[] args)
        {
            // Първи ред - дни за престой - цяло число в интервала [0...365]
            int days = int.Parse(Console.ReadLine());

            // Втори ред - вид помещение - "room for one person", "apartment" или "president apartment"
            string room = Console.ReadLine();

            // Трети ред - оценка - "positive" или "negative"
            string evaluation = Console.ReadLine();

            double discount = 0.00;
            double price = 0.00;

            // calculate discount depending of room type and days of residence into the hotel
            if (days < 10)
            {
                switch (room)
                {
                    case "room for one person": discount = 0.00; break;
                    case "apartment": discount = 30.00; break;
                    case "president apartment": discount = 10.00; break;
                };
            };

            if (days <= 15)
            {
                switch (room)
                {
                    case "room for one person": discount = 0.00;
                        break;
                    case "apartment": discount = 35.00; break;
                    case "president apartment": discount = 15.00; break;
                };
            }
            else
            {
                switch (room)
                {
                    case "room for one person": discount = 0.00; break;
                    case "apartment": discount = 50.00; break;
                    case "president apartment": discount = 20.00; break;
                };
            };

            switch (room)
            {
                case "room for one person": price = 18.00; break;
                case "apartment": price = 25.00; break;
                case "president apartment": price = 35.00; break;
            };

            price *= (days - 1);
            price = price * (1 - discount / 100);

            if (evaluation == "positive") { price *= 1.25; } else { price *= 0.9; };

            Console.WriteLine("{0:f2}", price);

        }
    }
}
