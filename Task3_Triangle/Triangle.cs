using System;
using System.Collections.Generic;
using System.Text;

namespace Task3_Triangle
{
    public class Triangle
    {
        /// <summary>
        /// Отсутствие set не дает менять стороны вне класса
        /// </summary>
        public double a { get; }
        public double b { get; }
        public double c { get; }

        public Triangle(double a, double b, double c)
        {
            //Проверка на существование
            if (a + b > c && b + c > a && c + a > b && a > 0 && b > 0 && c > 0)
            {
                this.a = a;
                this.b = b;
                this.c = c;
            }
            else
            {
                throw (new InvalidOperationException("Triangle with these sides doesn't exist"));
            }
        }

        public double CalculatePerimeter()
        {
            return a + b + c;
        }
        /// <summary>
        /// Площадь по формуле Герона
        /// Sqrt(p * (p - a) * (p - b) * (p - c))
        /// где p  полупериметр
        /// </summary>
        /// <returns></returns>
        public double CalculateSquare()
        {
            double p = CalculatePerimeter() / 2;
            double square = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            return square;
        }
    }
}
