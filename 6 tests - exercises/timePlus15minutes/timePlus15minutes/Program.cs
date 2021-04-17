using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace timePlus15minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            // read input data
            int hrs = int.Parse(Console.ReadLine());
            int min = int.Parse(Console.ReadLine());

            // min < 45 => hrs | (min + 15)
            // min = 45 => (hrs + 1) % 24 | "00"
            // min > 45 => (hrs + 1) | (min + 15) % 60

            if (min >= 45)
            {
                hrs = ((hrs + 1) % 24);
            }

            min = ((min + 15) % 60);

            if (min < 10)
            {
                Console.Write(hrs); Console.Write(":0"); Console.WriteLine(min);
                // Console.WriteLine($"{hrs}:0{min}");
            }
            else
            {
                Console.Write(hrs); Console.Write(":"); Console.WriteLine(min);
                // Console.WriteLine($"{hrs}:{min}");
            }
        }
    }
}
