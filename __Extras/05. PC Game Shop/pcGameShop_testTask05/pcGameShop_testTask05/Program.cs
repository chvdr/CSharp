using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace pcGameShop_testTask05
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            
            double hearthstone = 0;
            double fornite = 0;
            double overwatch = 0;
            double others = 0; 
            
            
            for (int i = 1; i <= n; i++)
            {
                string gameName = Console.ReadLine();
            
                if (gameName == "Hearthstone")
                {
                    hearthstone++;
                    //hearthstone+=1;
                }
                else if (gameName == "Fornite")
                {
                    fornite++;
                    //fornite = fornite + 1;
            
                }
                else if (gameName == "Overwatch")
                {
                    overwatch += 1;
                    //overwatch++;
            
                }
                else
                {
                    others++;
                }
            }
            
            double p1 = hearthstone / n * 100;
            double p2 = fornite / n * 100;
            double p3 = overwatch / n * 100;
            double p4 = others / n * 100;
            
            
            Console.WriteLine($"Hearthstone - {p1:F2}%");
            Console.WriteLine($"Fornite - {p2:F2}%");
            Console.WriteLine($"Overwatch - {p3:F2}%");
            Console.WriteLine($"Others - {p4:F2}%");
        }
    }
}
