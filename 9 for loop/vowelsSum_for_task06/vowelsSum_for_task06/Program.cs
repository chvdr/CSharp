﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace vowelsSum_for_task06
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int sum = 0;
            for (int i = 0; i < input.Length; i++)
            {
                switch (input[i])
                {
                    case 'a': sum += 1; break;
                    case 'e': sum += 2; break;
                    case 'i': sum += 3; break;
                    case 'o': sum += 4; break;
                    case 'u': sum += 5; break;

                }
            }
            
            //Console.WriteLine("Vowels sum = " + sum);
            Console.WriteLine(sum);
        }
    }
}