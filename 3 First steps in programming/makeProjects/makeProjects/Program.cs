﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace makeProjects
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int projects = int.Parse(Console.ReadLine()); 
            int hours = 3 * projects;
            
            // Console.WriteLine($"The architect {name} will need {hours} hours to complete {projects} project/s.";);
            Console.WriteLine("The architect " + name + " will need " + hours + " hours to complete " + projects + " project/s.");
        }
    }
}
