using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace fishTank
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("l: "); int l = int.Parse(Console.ReadLine());
            Console.Write("w: "); int w = int.Parse(Console.ReadLine());
            Console.Write("h: "); int h = int.Parse(Console.ReadLine());
            Console.Write("percent: "); double percent = double.Parse(Console.ReadLine());

            double litres = l * w * h * 0.001;
            Console.WriteLine((100 - percent) * 0.01 * litres);
        }
    }
}
