using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace areaOfFigures
{
    class Program
    {
        static void Main(string[] args)
        {
            string figure = Console.ReadLine();
            double result = 0;

            // List of figures
            // square, rectangle, circle or triangle

            if (figure == "square")
            {
                // please enter the square fence
                double fense = double.Parse(Console.ReadLine());
                result = fense * fense; 
            }
            else if (figure == "rectangle")
            {
                double a = double.Parse(Console.ReadLine());
                double b = double.Parse(Console.ReadLine());
                result = a * b; 
            }
            else if (figure == "circle")
            {
                double r = double.Parse(Console.ReadLine());
                result = Math.PI * r * r;
            }
            else if (figure == "triangle")
            {
                double a = double.Parse(Console.ReadLine());
                double ha = double.Parse(Console.ReadLine());
                result = a * ha * 0.5;
            }
            else
            {
                Console.WriteLine("ERROR: Wrong type of figure has picked. Exitting");
            }
            Console.WriteLine("{0:f3}", result);
        }
    }
}
