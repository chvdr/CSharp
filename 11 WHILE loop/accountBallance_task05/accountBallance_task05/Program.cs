using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace accountBallance_task05
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            double balance = 0.0;
            while (input != "Nomoremoney")
            {
                double amount = double.Parse(input);
                if (amount < 0) { Console.WriteLine("Invalid operation!"); break; };
                balance += amount;
                Console.Write("Increase: "); Console.WriteLine("{0:f2}", amount);
                input = Console.ReadLine();
            }

            Console.Write("Total: "); Console.WriteLine("{0:f2}", balance);

        }
    }
}
