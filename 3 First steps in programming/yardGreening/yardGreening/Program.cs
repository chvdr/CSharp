using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace yardGreening
{
    class Program
    {
        static void Main(string[] args)
        {
            double s = double.Parse(Console.ReadLine());
            double finalPrice = s * 7.61;
            double discount = finalPrice * 0.18;

            Console.WriteLine("The final price is: " + finalPrice * 0.82 + "lv. ");
            Console.WriteLine("The discount is: " + discount + "lv. ");
        }
    }
}
