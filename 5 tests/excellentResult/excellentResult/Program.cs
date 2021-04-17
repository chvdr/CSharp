using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace excellentResult
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.Write("grade: "); 
			double grade = double.Parse(Console.ReadLine());
            if (grade >= 5.50)
                Console.WriteLine("Excellent!");
        }
    }
}
