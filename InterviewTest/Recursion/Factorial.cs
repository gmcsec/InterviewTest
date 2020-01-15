using System;
using System.Collections.Generic;
using System.Text;

namespace InterviewTest.Recursion
{
    public class Factorial
    {
        public int GetFactorial(int number)
        {
            if (number < 0)
            {
                Console.WriteLine("Negative numbers cannot be used for Factorials.");
                return 0;
            }
            else if (number == 0) return 1;
            else
            {
                Console.WriteLine("GetFactorial of number: " + number);
                return number * GetFactorial(--number);
            }           
        }
    }
}
