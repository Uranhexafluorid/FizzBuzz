using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i <= 100; i++)
            {
                Console.WriteLine(FizzBuzz(i));
            }
                        
            Console.ReadLine();

        }

        /// <summary>
        /// This functions takes an integer, FizzBuzzes it and returns a string
        /// </summary>
        /// <param name="intNumber"></param>
        /// <returns></returns>
        static string FizzBuzz(int intNumber) 
        {
            // create string strOutput and set it to intNumber
            string strOutput = Convert.ToString(intNumber);

            // check for dividability
            bool boolDividableByThree = DividableBy(intNumber, 3);
            bool boolDividableByFive = DividableBy(intNumber, 5);

            // if dividable by three set strOutput to "Fizz"
            if (boolDividableByThree)
            {
                strOutput = "Fizz";
            }

            // if dividable by five set strOutput to "Buzz"
            if (boolDividableByFive)
            {
                strOutput = "Buzz";
            }

            // if dividable by both three and five set strOutput to "FizzBuzz"
            if (boolDividableByThree & boolDividableByFive)
            {
                strOutput = "FizzBuzz";
            }

            // return string strOutput
            return strOutput;
        }

        /// <summary>
        /// This function checks if two numbers are dividable and returns a bool.
        /// If the divisor is zero, the function returns false.
        /// </summary>
        /// <param name="intDividend"></param>
        /// <param name="intDivisor"></param>
        /// <returns></returns>
        static bool DividableBy(int intDividend, int intDivisor)
        {
            // check if intDivisor is not zero, else return false
            if ( intDivisor != 0)
            {
                // check if the dividend is dividable by the divisor
                return ((intDividend % intDivisor) == 0);
            }
            else
            {
                return false;
            }
        }
    }
}
