using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace b_dayParty
{
    class Program
    {
        static void Main(string[] args)
        {
            // Input
            Console.Write("Please enter the rent of the room: "); double rent = double.Parse(Console.ReadLine());

            double birthdayCace = rent / 5;
            double drinks = 0.55 * birthdayCace;
            double animator = rent / 3;

            // Console.WriteLine("Total price: " + (rent + birthdayCace + drinks + animator));
            Console.WriteLine(rent + birthdayCace + drinks + animator);
        }
    }
}
