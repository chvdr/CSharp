// Напишете конзолно приложение, което: 
// 
// (1). създава  два едномерни масива с по n-елемента и им присвоява  случайни числа в интервала [2;200]. 
// (2). Приложението да определя:
// (2.1) в кой от двата масива сумата на четните елементи е по-голяма
//  и 
// (2.2) дали минималните им елементи са равни.
// 
// Използвайте методи за:
// [1]. Присвояване на случайни числа на елементите на едномерен масив (генериране на масив)
// [2]. Извеждане на масив върху един ред
// [3]. Намиране сумата на нечетните елементи в едномерен масив
// [4]. Намиране на най-малката стойност в едномерен масив
// Изпратете: 
// текстов файл с кода на приложението
// снимка (скрийншот) на конзолата при тест на приложението

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace arrayFourNumbers
{
    class Program
    {
        export int const n = 4; 				// how long/powerful will be our Arrays. Uses as a Constant

		// [1]. Присвояване на случайни числа на елементите на едномерен масив (генериране на масив)
		static void generateArray (int[] arr) {
			Random rnd = new Random();
			// local int i;
			for (int i = 1; i < n; i++) {
				arr[i] = rnd.Next(2, 200);
			}
		}
		
		// [2]. Извеждане на масив върху един ред
		static void print (int[] arr) {
			for (int i = 0; i < n; i++) {
				Console.Write(arr[i] + " ");
			}
		}
		
		// [3]. Намиране сумата на нечетните елементи в едномерен масив
		static int SumEven (int[] arr) {
			int SUM=0; 
			for (int i = 0; i < n; i++) {
				if (arr[i]%2 != 0){ 
					SUM += arr[i]; 
				}
			}
			return SUM; 
		}
		
		// [4]. Намиране на най-малката стойност в едномерен масив
        static int min(int[] arr)
        {
            int MINIMUM = arr[0];
            for (int i = 0; i < n; i++)
            {
                if (arr[i] < MINIMUM)
                {
                    MINIMUM = arr[i];
                }
                // return MINIMUM;
            } // static int min (int[] arr) {
            return MINIMUM;
        }
	
/*		
		 #     #          #          ###       #     #    
		 ##   ##         # #          #        ##    #
		 # # # #        #   #         #        # #   #
		 #  #  #       #     #        #        #  #  #
		 #     #       #######        #        #   # #
		 #     #       #     #        #        #    ##
		 #     #       #     #       ###       #     #
*/                                                  
        static void Main(string[] args)
        {

            // int n = 4; 				// how long/powerful will be our Arrays. Uses as a Constant
            int[] a = new int[n];	// 1st array 
            int[] b = new int[n];	// 2nd array
			// (1). създава  два едномерни масива с по n-елемента и им присвоява  случайни числа в интервала [2;200]. 
			// statis void generateArray () is in use to generate arrays 'a' and 'b':
            generateArray(a); print(a); Console.WriteLine();
            generateArray(b); print(b); Console.WriteLine();

			// (2.1) в кой от двата масива сумата на четните елементи е по-голяма
			if (SumEven(a) > SumEven(b)) {
				Console.WriteLine("The sum of even numbers in A is bigger");
			}
			else {
				Console.WriteLine("The sum of even numbers in B is bigger");
			}
			
			// (2.2) дали минималните им елементи са равни. 
			if (min(a) > min(b)) {
				Console.WriteLine("minimal elements in a and be ARE EQUAL");
			}
			else {
				Console.WriteLine("minimal elements in a and be are NOT equal");
			}



        } // static void Main(string[] args)
    } // class Program
}