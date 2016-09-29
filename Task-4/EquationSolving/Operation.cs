using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EquationSolving
{
    public class Operation
    {
        public float SolveLinearEquation(float coefficientA, float coefficientB)
        {
            float radical = (float)-coefficientB / coefficientA;
            return radical;
        }

        public List<double> SolveQuadraticEquation(float coefficientA, float coefficientB, float coefficientC)
        {
            List<double> roots = new List<double>(); 
            float D = ((coefficientB * coefficientB) - (4 * coefficientA * coefficientC));
            if (D == 0)
            {
                double x1 = (-coefficientB + Math.Sqrt(D)) / (2 * coefficientA);
                roots.Add(x1);
                
            } else if (D < 0)
            {
                
            } else if (D > 0)
            {
                double x1 = (-coefficientB + Math.Sqrt(D)) / (2 * coefficientA);
                double x2 = (-coefficientB - Math.Sqrt(D)) / (2 * coefficientA);
                roots.Add(x1);
                roots.Add(x2);
                
            }
            return roots;
        }
        
        public float MatrixMultiplication(string filePath)
        {



            return 0;
        }
    }
}
