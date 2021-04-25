using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace tradeCommissions
{
    class Program
    {
        static void Main(string[] args)
        {
            string town = Console.ReadLine();
            bool townValid = ((town == "Sofia") || (town == "Plovdiv") || (town == "Varna"));

            double s = double.Parse(Console.ReadLine());
            bool sValid = (s >= 0);

            double profit = 0.00;       // profit in percents
            double commission = 0.00;   // this is real profit in money, commission = s * (profit/100); depending of the town and purchases

            if (!((townValid) && (sValid)))
            { 
                Console.WriteLine("error"); 
            }
            else
            {
                if (s <= 500)
                {
                    switch (town)
                    {
                        case "Sofia": profit = 5; break;
                        case "Varna": profit = 4.5; break;
                        case "Plovdiv": profit = 5.5; break; 
                    }
                }
                else if (s <= 1000)
                {
                    switch (town)
                    {
                        case "Sofia": profit = 7; break;
                        case "Varna": profit = 7.5; break;
                        case "Plovdiv": profit = 8; break;
                    }
                }
                else if (s <= 10000)
                {
                    switch (town)
                    {
                        case "Sofia": profit = 8; break;
                        case "Varna": profit = 10; break;
                        case "Plovdiv": profit = 12; break;
                    }
                }
                else 
                {
                    switch (town)
                    {
                        case "Sofia": profit = 12; break;
                        case "Varna": profit = 13; break;
                        case "Plovdiv": profit = 14.5; break;
                    }
                } // if (s <= 10000) --> else 
                // commission = s * (profit/100);
                commission = s * (profit / 100);

                Console.WriteLine("{0:f2}", commission);
            } // profit is calculated (NOTE: profit is in percentage!!!)

            
            

            
        }
    }
}
