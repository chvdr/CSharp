using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace cleverLilly_Task11_exam
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = int.Parse(Console.ReadLine());
            double laundryPrice = double.Parse(Console.ReadLine());
            double toysPrice = double.Parse(Console.ReadLine());
            
            double totalMoney = 0;
            int evenAgeSavings = 1;
            
            for (int i = 1; i <= age; i++)
            {
                if(i % 2 == 0)
                {
                    totalMoney += (10 * evenAgeSavings++) - 1;
                }
                else
                {
                    totalMoney += toysPrice;
                }
            }
            
            if(totalMoney >= laundryPrice)
            {
                // Console.WriteLine($"Yes! {(totalMoney - laundryPrice):F2} ");
                Console.Write("Yes! "); Console.WriteLine("{0:f2}", (totalMoney - laundryPrice));
            }
            else
            {
                // Console.WriteLine($"No! {(laundryPrice - totalMoney):F2}");
                Console.Write("No! "); Console.WriteLine("{0:f2}", (laundryPrice - totalMoney));
            }
        }
    }
}
