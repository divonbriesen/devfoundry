using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EulerOne
{
    class Euler1
    {

        public static void Main(String[] args)
        {
            Console.WriteLine("Euler 1 is: " + SolveEuler1());
        }

        static int SolveEuler1()
        {
            //Find the sum of all the multiples of 3 or 5 below 1000.

            int sum = 0;

            OutputLibrary.OutputService.DisplayOutput("Please enter the top/ending number of your range for Euler One: ");  
            string sTopRange = InputLibrary.InputService.GetLine();

            bool bIsInt = ValidationLibrary.ValidationService.ValidateInt(sTopRange);
      //      bool bIsLong = ValidationLibrary.ValidationService.ValidateLong(sTopRange);

            int iTopRange = 0;
          //  long lTopRange;

            if (bIsInt)
            {
                iTopRange = ConversionLibrary.ConversionService.ConvertStringToInt(sTopRange);
            }
         /*   else if (bIsLong) // not an int
            {
                lTopRange = ConversionLibrary.ConversionService.ConvertStringToLong(sTopRange);
            }  */
            else
            {
                Console.WriteLine("Not a valid number: Game over...");
            }


            OutputLibrary.OutputService.DisplayOutput("Please enter the the first value you want to divide by (less than 1000): ");
            string sFirstNumber = InputLibrary.InputService.GetLine();

            bIsInt = ValidationLibrary.ValidationService.ValidateInt(sFirstNumber);
            int iFirstNumber = 0; 

            if (bIsInt)
            {
                iFirstNumber = ConversionLibrary.ConversionService.ConvertStringToInt(sFirstNumber);
            }
            else
            {
                Console.WriteLine("Not a valid first number: Game over...");
            }


            OutputLibrary.OutputService.DisplayOutput("Please enter the second value you want to divide by(less than 1000): ");
            string sSecondNumber = InputLibrary.InputService.GetLine();
            
            bIsInt = ValidationLibrary.ValidationService.ValidateInt(sSecondNumber);
            int iSecondNumber = 0;

            if (bIsInt)
            {
                iSecondNumber = ConversionLibrary.ConversionService.ConvertStringToInt(sSecondNumber);
            }
            else
            {
                Console.WriteLine("Not a valid second number: Game over...");
            }
           

            for (int i = 0; i < iTopRange; i++)
            {

                if (((i % iFirstNumber) == 0) || ((i % iSecondNumber) == 0))
                {
                    sum += i;
                }
            } // end for

            return sum;
        } // end SolveEuler1
    } // end class
} // end namespace
