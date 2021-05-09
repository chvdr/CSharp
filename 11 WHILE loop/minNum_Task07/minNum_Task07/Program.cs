using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace minNum_Task07
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine(); int min = int.MaxValue;
            while (input != "Stop") { int num = int.Parse(input); if (num < min) { min = num; }; input = Console.ReadLine(); };
            Console.WriteLine(min); 
        }
    }
}
