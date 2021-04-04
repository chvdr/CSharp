using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace converterRADtoDEG
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.Write("Please enter the angle in RADIANS: "); 
            double radians = double.Parse(Console.ReadLine());
            double degrees = radians * 180 / Math.PI;

            // Console.WriteLine("Value (DEG): " + Math.Round(degrees));
            Console.WriteLine(Math.Round(degrees));
        }
    }
}
