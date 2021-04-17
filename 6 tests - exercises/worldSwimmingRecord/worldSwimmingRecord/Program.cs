using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace worldSwimmingRecord
{
    class Program
    {
        static void Main(string[] args)
        {

            // Вход
            // От конзолата се четат 3 реда:
            // 1 Рекордът в секунди – реално число в интервала [0.00 … 100000.00]
            // 2 Разстоянието в метри – реално число в интервала [0.00 … 100000.00]
            // 3 Времето в секунди, за което плува разстояние от 1 м. - реално число в интервала [0.00 … 1000.00]

            // Console.Write("Enter World Record (in seconds): ");
            double worldRecord = double.Parse(Console.ReadLine());

            // Console.Write("Distance (m) = ");
            double distance = double.Parse(Console.ReadLine());

            // Console.Write("Swimming Time to pass 1 meter (s) = ");
            double time = double.Parse(Console.ReadLine());

            // # Световен рекорд по плуване
            // Иван решава да подобри Световния рекорд по плуване на дълги разстояния. На
            // конзолата се въвежда рекордът в секунди, който Иван трябва да подобри,
            // разстоянието в метри, което трябва да преплува и времето в секунди, за което плува
            // разстояние от 1 м. Да се напише програма, която изчислява дали се е справил със
            // задачата, като се има предвид, че: съпротивлението на водата го забавя на всеки 15
            // м. с 12.5 секунди. Когато се изчислява колко пъти Иванчо ще се забави, в резултат на
            // съпротивлението на водата, резултатът трябва да се закръгли надолу до най-близкото
            // цяло число.

            double waterResistance = Math.Floor((distance / 15) * 12.5);
            double totalTime = waterResistance + distance * time;
            Console.Write("distance * time = "); Console.WriteLine(distance * time);
            Console.Write("waterResistance = "); Console.WriteLine("{0:f2}", waterResistance); 
            Console.Write("waterResistance + distance * time = "); Console.WriteLine(totalTime); 
            if (totalTime < worldRecord)
            {
                Console.Write("Yes, he succeeded! The new world record is "); Console.Write("{0:f2}", totalTime); Console.WriteLine(" seconds.");
            }
            else
            {
                Console.Write("No, he failed! He was "); Console.Write("{0:f2}", (totalTime - worldRecord)); Console.WriteLine(" seconds slower.");
            }	

        }
    }
}
