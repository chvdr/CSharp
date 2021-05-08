using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace histogram_task4
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            
            double p1 = 0.00;
            double p2 = 0.00;
            double p3 = 0.00;
            double p4 = 0.00;
            double p5 = 0.00;
            
            for (int i = 1; i <= n; i++)
            {
                int num = int.Parse(Console.ReadLine());
            
                if (num < 200)
                {
                    //p1 = p1 + 1;
                    //p1+=1;
                    p1++;
                }
                else if (num < 400)
                {
                    p2++;
                }
                else if (num < 600)
                {
                    p3++;
                }
                else if (num < 800)
                {
                    p4++;
                }
                else
                {
                    p5++;
                }
            }

            p1 = p1 / n * 100; Console.Write("{0:f2}", p1); Console.WriteLine("%");
            p2 = p2 / n * 100; Console.Write("{0:f2}", p2); Console.WriteLine("%");
            p3 = p3 / n * 100; Console.Write("{0:f2}", p3); Console.WriteLine("%");
            p4 = p4 / n * 100; Console.Write("{0:f2}", p4); Console.WriteLine("%");
            p5 = p5 / n * 100; Console.Write("{0:f2}", p5); Console.WriteLine("%"); 

            // Console.WriteLine($"{p1:F2}%");
            // Console.WriteLine($"{p2:F2}%");
            // Console.WriteLine($"{p3:F2}%");
            // Console.WriteLine($"{p4:F2}%");
            // Console.WriteLine($"{p5:F2}%");
        }
    }
}
