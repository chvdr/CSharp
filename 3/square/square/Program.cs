﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace square
{
    class Program
    {
        static void Main(string[] args)
        {
            int side = int.Parse(Console.ReadLine());
            int area = side * side;
            Console.WriteLine(area); 
        }
    }
}
