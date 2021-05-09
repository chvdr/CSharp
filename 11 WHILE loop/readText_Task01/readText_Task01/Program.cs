using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace readText_Task01
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
            	string name = Console.ReadLine();
            	if (name == "Stop") { break; }; 
            	
            	// write to output 
            	Console.WriteLine(name); 
            }
        }
    }
}
