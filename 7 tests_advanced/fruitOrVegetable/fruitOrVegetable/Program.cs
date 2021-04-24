using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace fruitOrVegetable
{
    class Program
    {
        static void Main(string[] args)
        {
            // fruit: banana, aple, kiwi, cherry, lemon, grapes
            // vegetable: tomato, cucumber, pepper, carrot

            string product = Console.ReadLine();

            switch (product)
            {
                case "banana":
                case "apple":
                case "kiwi":
                case "cherry":
                case "lemon":
                case "grapes": Console.WriteLine("fruit"); break;
                case "carrot":
                case "pepper":
                case "cucumber":
                case "tomato": Console.WriteLine("vegetable"); break;
                default: Console.WriteLine("unknown"); break;
            }
        }
    }
}
