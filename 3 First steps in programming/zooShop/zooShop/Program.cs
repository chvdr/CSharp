using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace zooShop
{
    class Program
    {
        static void Main(string[] args)
        {
            int dogs = int.Parse(Console.ReadLine()); 
            int others = int.Parse(Console.ReadLine());
            
            double sum = dogs * 2.5 + others * 4.0;
            
            Console.WriteLine(sum + " lv.");
        }
    }
}
