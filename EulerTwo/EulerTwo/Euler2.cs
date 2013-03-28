using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EulerTwo
{
    class Euler2
    {
        public static void Main(String[] args)
        {
            Console.WriteLine("Euler 2 is: " + SolveEuler2());
        }

        static long SolveEuler2()
        {
            // By considering the terms in the Fibonacci sequence whose values 
            // do not exceed four million, find the sum of the even-valued terms.
            long sum = 0;
            int fib1 = 0; // need to start with zero to be sure 2 gets counted
            int fib2 = 1;

            for (int i = 0; fib2 < 4000000; i++)
            {
                int fibNew = fib1 + fib2;

                fib1 = fib2;
                fib2 = fibNew;  
                if ((fib2 % 2) == 0) // number is even
                {
                    sum += fib2;
                }
            } // end for

            return sum;
        } // end SolveEuler method
    }
}
