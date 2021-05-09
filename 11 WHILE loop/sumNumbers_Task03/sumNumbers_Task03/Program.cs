using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace sumNumbers_Task03
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            while (sum < n) { int currentNum = int.Parse(Console.ReadLine()); sum += currentNum; }
            Console.WriteLine(sum);
        }
    }
}
