using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace passwordGuess
{
    class Program
    {
        static void Main(string[] args)
        {
            string saved_password = "s3cr3t!P@ssw0rd";
            string input_password = Console.ReadLine();

            if (saved_password == input_password)
            {
                Console.WriteLine("Welcome");
            }
            else
            {
                Console.WriteLine("Wrong password!");
            }
        }
    }
}
