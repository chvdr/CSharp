using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace number100_200
{
    class Program
    {
        static void Main(string[] args)
        {
            int h = int.Parse(Console.ReadLine());
            if (h < 100)
            {
                Console.WriteLine("Less than 100");
            }
            else
            {
                if (h <= 200)
                {
                    Console.WriteLine("Between 100 and 200");
                }
                else
                {
                    Console.WriteLine("Greater than 200");
                }
            }
        }
    }
}
