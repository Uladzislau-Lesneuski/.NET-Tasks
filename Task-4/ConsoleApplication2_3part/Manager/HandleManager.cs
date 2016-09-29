using System;
using EquationSolving;
using System.Collections.Generic;

namespace ConsoleApplication2_3part
{
    class HandleManager
    {
        private static Operation ACTION = new Operation();
        private static Logger LOG = new Logger();

        List<double> roots = new List<double>();

        public void Launch(Equation equation)
        {
            
            try
            {
                if (equation != null)
                {
                    if (equation.EquationType == 1)
                    {
                        //расчет линейного уравнения
                        roots.Add(ACTION.SolveLinearEquation(equation.coefficientA, equation.coefficientB));
                        // проверка на целое число
                        if (roots[0] % 1 == 0)
                        {
                            Console.WriteLine("Linear equation root is = " + roots[0].ToString());
                        // вывод корня с точность до 2 знаков после нуля
                        } else Console.WriteLine("Linear equation root is = " + "{0:F2}", roots[0]);
                        LOG.WriteEquantionToLog(equation, roots);     
                    } else
                    {
                        //расчет квадратного уравнения
                        roots = ACTION.SolveQuadraticEquation(equation.coefficientA, equation.coefficientB, equation.coefficientC);
                        // проверка на целое число
                        if (roots[0] % 1 == 0)
                        {
                            Console.WriteLine("Quadratic equations roots is = " + roots[0].ToString() + " and " + roots[1].ToString());
                        // вывод корней с точность до 2 знаков после нуля
                        } else Console.WriteLine("Quadratic equations roots is = " + "{0:F2}", roots[0].ToString() + " and " + "{0:F2}", roots[1].ToString() );
                        LOG.WriteEquantionToLog(equation, roots);
                    }
                }
                else Console.WriteLine("Check entered params");
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
