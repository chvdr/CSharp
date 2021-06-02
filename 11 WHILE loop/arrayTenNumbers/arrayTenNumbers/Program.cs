using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace arrayTenNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 10;
            int[] a = new int[n];
            
            // counters:
            int c = 0; int i = 1000;
            
            // temp variables
            int edn = 0; int dec = 0; int sto = 0; int hil = 0;
            Random rnd = new Random();
            
            while ((i < 9999)&&(c < n)) {

                edn = i % 10; 
                dec = (i / 10) % 10; 
                sto = (i / 100) % 10; 
                hil = (i / 1000) % 10;

            	if ((edn + dec + sto + hil) == 11) 
                {
            		a[c] = i;
            		c++;
            	}

                i = rnd.Next(1000, 9999);
            }

            n = c; 
            
            int min = a[0]; int max = a[0];

            for (int j = 1; j < n; j++) {
            	if (a[j] > max) 
            		max = a[j];
            	if (a[j] < min) 
                    min = a[j];
            }

            Console.WriteLine(max - min);
        }
    }
}
