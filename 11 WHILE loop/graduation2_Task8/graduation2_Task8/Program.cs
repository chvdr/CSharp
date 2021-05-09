using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace graduation2_Task8
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int grades = 1;
            double sum = 0;
            int excluded = 0;
            while (grades <= 12)
            {
                double grade = double.Parse(Console.ReadLine());
                sum += grade;
                if (grade < 4.00)
                {
                    excluded += 1;
                    if (excluded > 1) { Console.WriteLine(name + " has been excluded at " + grades + " grade"); break; };
                    continue;
                }
                grades += 1;
            }
            double average = sum / 12;
            if (excluded <= 1) { Console.Write(name + " graduated. Average grade: "); Console.WriteLine("{0:f2}", average); };    
        }  
    }
}
