using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace calculatorDeposit
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Deposit: "); double deposit = double.Parse(Console.ReadLine());
            Console.Write("Deposit interval (months): "); int months = int.Parse(Console.ReadLine());
            Console.Write("Yearly revenue (in %): "); double revenue = double.Parse(Console.ReadLine()) / 100;

            Console.WriteLine(deposit + months * (deposit * revenue)/12); 
        }
    }
}
