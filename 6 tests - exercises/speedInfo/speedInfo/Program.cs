using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace speedInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            // task 3: Speed validation
            // DIRECTORY: C:\Users\Sunrise GW\Desktop\SOU\SU\homeWork11042021
            // FILENAME: task3_speed.cs

            // input 
            double speed = double.Parse(Console.ReadLine());

            // step1 
            // if (){}
            // else if (){}
            // else if (){}
            // else if (){}
            // else {}

            // step2
            // if (speed <= 10){Console.WriteLine("slow");}
            // else if (speed <= 50){Console.WriteLine("average");}
            // else if (speed <= 150){Console.WriteLine("fast");}
            // else if (speed <= 1000){Console.WriteLine("ultra fast");}
            // else {Console.WriteLine("extremely fast");}

            if (speed <= 10)
            {
                Console.WriteLine("slow");
            }
            else if (speed <= 50)
            {
                Console.WriteLine("average");
            }
            else if (speed <= 150)
            {
                Console.WriteLine("fast");
            }
            else if (speed <= 1000)
            {
                Console.WriteLine("ultra fast");
            }
            else
            {
                Console.WriteLine("extremely fast");
            }
        }
    }
}
