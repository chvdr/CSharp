using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace sumSeconds
{
    class Program
    {
        static void Main(string[] args)
        {
            // FILE: C:\Users\Sunrise GW\Desktop\SOU\SU\homeWork11042021
            
            // read input data
            int firstTime  = int.Parse(Console.ReadLine());
            int secondTime = int.Parse(Console.ReadLine());
            int thirdTime  = int.Parse(Console.ReadLine());
            
            // total time - sum of input data
            int totalTime = firstTime + secondTime + thirdTime; 
            
            // DIV and MOD -- minutes and seconds
            // NOTE: 'minutes' and 'seconds' are reserverd words in C#, so
            // using them as a variable names is not a good idea, using 'min' and 'sec' instead
            int min = totalTime / 60;
            int sec = totalTime % 60; 
            
            if (sec < 10)
            {
            	Console.WriteLine($"{min}:0{sec}");
            }
            else 
            {
            	Console.WriteLine($"{min}:{sec}");
            }
        }
    }
}
