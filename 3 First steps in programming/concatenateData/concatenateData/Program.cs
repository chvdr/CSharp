using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace concatenateData
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName = Console.ReadLine();
            string lastName = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            string town = Console.ReadLine();
            // Console.WriteLine($"You are {firstName} {lastName}, a {age}-year old person from {town}."); 
            Console.WriteLine("You are " + firstName + " " + lastName + ", a" + age + "-year old person from " + town); 
        }
    }
}
