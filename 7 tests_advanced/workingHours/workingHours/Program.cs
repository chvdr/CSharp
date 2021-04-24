using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace workingHours
{
    class Program
    {
        static void Main(string[] args)
        {
            // 10-18
            // Monday-Saturday
            int hour = int.Parse(Console.ReadLine());
            string day = Console.ReadLine();

            switch (day)
            {
                case "Sunday": Console.WriteLine("closed"); break; 
                default:
                    if (hour >= 10 && hour <= 18)
                    {
                        Console.WriteLine("open");
                    }
                    else
                    {
                        Console.WriteLine("closed");
                    }
                    break;
            }
        }
    }
}
