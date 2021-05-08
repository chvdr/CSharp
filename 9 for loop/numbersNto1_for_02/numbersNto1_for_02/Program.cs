using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace numbersNto1_for_02
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = n; i >=1; i--)
            {
                Console.WriteLine(i);
            }
        }
    }
}
