using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace evenOrOdd
{
    class Program
    {
        static void Main(string[] args)
        {
            int h = int.Parse(Console.ReadLine());

            if (h % 2 == 0)
            {
                Console.WriteLine("even");
            }
            else
            { 
                Console.WriteLine("odd"); 
            }
        }
    }
}
