using System;

namespace Task3_Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            string flag;
            do
            {
                Console.WriteLine("Введите стороны треугольника");
                double a = Convert.ToDouble(Console.ReadLine());
                double b = Convert.ToDouble(Console.ReadLine());
                double c = Convert.ToDouble(Console.ReadLine());
                try
                {
                    Triangle t = new Triangle(a, b, c);
                    Console.WriteLine("Периметр");
                    Console.WriteLine(t.CalculatePerimeter());
                    Console.WriteLine("Площадь");
                    Console.WriteLine(t.CalculateSquare());
                }
                catch (InvalidOperationException e)
                {
                    Console.WriteLine(e.Message);            
                }
                    Console.WriteLine("\nЧтобы повторить введите 1, чтобы закончить - любое значение");
                    flag = Console.ReadLine();

            } while (flag == "1");



        }
    }
}
