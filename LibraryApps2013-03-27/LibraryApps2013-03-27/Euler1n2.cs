using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryApps2013_03_27
{
    class Euler1n2
    {

        public static void Main(String[] args)
        {
            Console.WriteLine("Euler 1 is: " + SolveEuler1());
            Console.WriteLine("Euler 2 is: " + SolveEuler2());
        }

        static int SolveEuler1()
        {
            //Find the sum of all the multiples of 3 or 5 below 1000.

            int sum = 0;

            for (int i = 0; i < 1000; i++)
            {

                if(((i % 3) == 0) || ((i % 3) == 0))
                {
                    sum += i;
                }
            } // end for

            return sum;
        }

        static int SolveEuler2()
        {
            // By considering the terms in the Fibonacci sequence whose values 
            // do not exceed four million, find the sum of the even-valued terms.
            int sum = 0;
            int fib1 = 0; // need to start with zero to be sure 2 gets counted
            int fib2 = 1;

            for (int i = 0; i < 4000000; i++)
            {
                int fibTemp = fib2;

                fib2 = fib1 + fib2; // overwrite fib2 with sum of the two to be new fib 2
                fib1 = fibTemp;  // overwrite fib2 with original fib1
                if (fib2 % 2 == 0) // number is even
                {
                    sum += fib2; 
                }
            }

            return sum; 
        }
    }
}
