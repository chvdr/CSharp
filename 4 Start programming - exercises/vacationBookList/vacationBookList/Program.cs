using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace vacationBookList
{
    class Program
    {
        static void Main(string[] args)
        {
            // vacationBookList
            // prints how many hours Joro will read every day to complete the current book in time 

            // vacationBookList variables table/list
            int pages;      // number of pages in the book Joro currently reading 
            double pph;        // pages per hour - Joro's reading speed ability 
            int days;       // number of days the book should be finished

            // input 
            Console.Write("pages of the book: "); pages = int.Parse(Console.ReadLine());
            Console.Write("reading speed (pages per hour): "); pph = int.Parse(Console.ReadLine());
            Console.Write("Days: "); days = int.Parse(Console.ReadLine());

            Console.WriteLine(pages / pph / days);
        }
    }
}
