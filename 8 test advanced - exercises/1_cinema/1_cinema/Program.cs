using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _1_cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            int rows = int.Parse(Console.ReadLine());
            int cols = int.Parse(Console.ReadLine());
            double income = 0.0; 

            if (type == "Premiere")
            {
                income = rows * cols * 12.00;
            }
            else if (type == "Normal")
            {
                income = rows * cols * 7.50;
            }
            else if (type == "Discount")
            {
                income = rows * cols * 5.00;
            }

            Console.Write("{0:f2}", income); Console.WriteLine( " leva"); 
        }
    }
}
