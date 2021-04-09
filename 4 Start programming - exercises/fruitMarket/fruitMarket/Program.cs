using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace fruitMarket
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("ia_prc: "); double ia_prc = double.Parse(Console.ReadLine());
            Console.Write("ba: "); double ba = double.Parse(Console.ReadLine());
            Console.Write("po: "); double po = double.Parse(Console.ReadLine());
            Console.Write("ma: "); double ma = double.Parse(Console.ReadLine());
            Console.Write("ia: "); double ia = double.Parse(Console.ReadLine());
            double ma_prc = ia_prc * 0.5;
            double po_prc = 0.6 * ma_prc;
            double ba_prc = 0.2 * ma_prc;
            double sum = ba * ba_prc + po * po_prc + ma * ma_prc + ia * ia_prc;
            Console.WriteLine("{0:f2}", sum);
        }
    }
}
