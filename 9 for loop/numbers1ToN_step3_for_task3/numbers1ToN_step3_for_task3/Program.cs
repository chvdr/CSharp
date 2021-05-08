using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace numbers1ToN_step3_for_task3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i += 3)
                Console.WriteLine(i);
        }
    }
}
