using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace remuneration_task6
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int salary = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                string website = Console.ReadLine();

                if (website == "Facebook") { salary = salary - 150; }
                else if (website == "Instagram") { salary = salary - 100; }
                else if (website == "Reddit") { salary = salary - 50; }

                if (salary <= 0) { Console.WriteLine("You have lost your salary."); break; }
            }

            if (salary > 0) { Console.WriteLine(salary); }
        }
    }
}
