using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace sequence2Kplus1_task04
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int k = 1;
            while (k <= n) { Console.WriteLine(k); k = 2 * k + 1; }
            // 1, 3, 7, 15, ...
        }
    }
}
