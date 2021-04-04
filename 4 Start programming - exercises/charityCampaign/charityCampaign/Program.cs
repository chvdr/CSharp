using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace charityCampaign
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int coockers = int.Parse(Console.ReadLine());
            int cake = int.Parse(Console.ReadLine());
            int waffles = int.Parse(Console.ReadLine());
            int pancake = int.Parse(Console.ReadLine());

            Console.WriteLine(((cake * 45 + waffles * 5.80 + pancake * 3.20) * days * coockers) * 7 / 8);        
        }
    }
}
