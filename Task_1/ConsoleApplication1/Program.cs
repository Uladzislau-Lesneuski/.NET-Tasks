using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CalculationsClassLibrary;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1 = Int32.Parse(Console.ReadLine());
            int number2 = Int32.Parse(Console.ReadLine());

            Console.WriteLine(number1 + number2);

            Calculations calc = new Calculations();

            Console.WriteLine(calc.addition(number1, number2));
            Console.WriteLine(calc.subtraction(number1,number2));
            Console.WriteLine(calc.multiplication(number1, number2));
            Console.WriteLine(calc.division(number1, number2));




            Console.ReadLine();
        }
    }
}
