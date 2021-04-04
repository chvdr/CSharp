using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace calculatorUSDtoBGN
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("USD: "); double usd = double.Parse(Console.ReadLine());
            //Console.WriteLine("Confirmation: " + usd + " USD are accepted. ");
            double bgn = usd * 1.79549;

            Console.WriteLine("BGN: " + bgn);
        }
    }
}
