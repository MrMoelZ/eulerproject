using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Euler1
{
    class Program
    {
        private static  int [] numbers = new int [1000];
        private static int y=0, counter=0;
        private static long sum = 0;

        static long calc()
        {
            for (int x = 0; x < 1000; x++)
            {
                if (x % 5 == 0)
                {
                    numbers[y] = x;
                    y++;
                    counter++;
                }
                else if (x % 3 == 0)
                {
                    if (x % 5 != 0)
                    {
                        numbers[y] = x;
                        y++;
                        counter++;
                    }
                }
            }
            for (int z = 0; z < counter; z++)
            {
                sum += numbers[z];
            }
            return sum;
        }       

        static void Main(string[] args)
        {
            Console.WriteLine("Euler 1\n");
            Console.WriteLine("If we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3, 5, 6 and 9. The sum of these multiples is 23. Find the sum of all the multiples of 3 or 5 below 1000.\n");
            Console.WriteLine("\n"+calc());
            Console.Read();
        }



    }
}
