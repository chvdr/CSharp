using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace metricConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            // INPUT
            // Първи ред: число за преобразуване - реално число
            // Втори ред: входна мерна единица - текст
            // Трети ред: изходна мерна единица (за резултата) - текст

            double number = double.Parse(Console.ReadLine());
            double result = 0;

            string inputUnit = Console.ReadLine();
            string outputUnit = Console.ReadLine();

            if (inputUnit == "m")
                if (outputUnit == "cm")
                    result = number * 100;
                else
                    result = number * 1000;
            else if (inputUnit == "cm")
                if (outputUnit == "m")
                    result = number / 100;
                else
                    result = number * 10;
            else if (inputUnit == "mm")
                if (outputUnit == "m")
                    result = number / 1000;
                else
                    result = number / 10;

            Console.WriteLine("{0:f3}", result);
        }
    }
}
