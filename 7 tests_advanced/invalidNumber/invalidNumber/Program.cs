﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace invalidNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            bool isValid = ((n > 10) && (n % 2 == 0));

            if (!isValid)
            {
                Console.WriteLine("Invalid");
            }
        }
    }
}
