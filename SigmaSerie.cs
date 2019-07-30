using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    class SigmaSerie
    {
        double k = 0;
        double n = 0;
        public void InputValues()
        {
            Console.WriteLine("");
            Console.WriteLine("---------------------------------- Sigma Serie Option -------------------------------");
            Console.WriteLine("With the following expression, where n is the initial value and k is the final value:");
            Console.WriteLine("     n");
            Console.WriteLine("     (\u03a3) ((-1)^(k+1)) / (2k-1)");
            Console.WriteLine("     k");
            Console.Write("Enter the value of k = ");
            k = int.Parse(Console.ReadLine());
            Console.Write("Enter the value of n = ");
            n = int.Parse(Console.ReadLine());
        }

        public double CalculateExpression()
        {
            double numerator, denominator, result, finalResult = 0;
            for (double i = k; i <= n; i++)
            {
                numerator = Math.Pow(-1, i + 1);
                denominator = (2 * i) - 1;
                result = numerator / denominator;

                finalResult = result + finalResult;
            }

            return finalResult;
        }
    }
}
