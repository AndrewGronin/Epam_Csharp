using System;
using System.Collections.Generic;
using System.Text;

namespace Task1_NthRoot
{
    static class  NthRoot
    {
        public static double result ;
        public static double resultWithPow;

        public static void CalculateRoot(double x , double n , double eps = 1e-5) 
        {
            if (x < 0) 
            {
                Console.WriteLine("Нельзя взять корень от отрицательного числа");
                result = -1;
                resultWithPow = -1;
            }
            else
            if (n <= 0)
            {
                Console.WriteLine("Степень корня должна быть положительна");
                result = -1;
                resultWithPow = -1;
            }
            else
            if (x == 0)
            {
                result = 0;
                resultWithPow = 0;
            }
            else
            {

                double x0 = 1;
                double xk = 1;

                do
                {
                    x0 = xk;
                    xk = x0 * (1 - (1 - (x / Math.Pow(x0, n))) / n);
                } while (Math.Abs(xk - x0) > eps);

                result = xk;
                resultWithPow = Math.Pow(x, 1 / n);
            }
        }

        public static double CompareWithPow()
        {
            return Math.Abs(result - resultWithPow);

        }
    }
}
