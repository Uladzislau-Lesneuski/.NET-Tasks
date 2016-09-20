using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CalculationsClassLibrary
{
    public class Calculations
    {
        public int addition(int number1, int number2)
        {
            int sum = 0;
            sum = number1 + number2;
            return sum;
        }

        public int subtraction(int number1, int number2)
        {
            int difference = 0;
            difference = number1 - number2;
            return difference;
        }

        public int multiplication(int number1, int number2)
        {
            int composition = 0;
            composition = number1 * number2;
            return composition;
        }

        public int division(int number1, int number2)
        {
            int quotient = 0;
            quotient = number1 / number2;
            return quotient;
        }
    }
}
