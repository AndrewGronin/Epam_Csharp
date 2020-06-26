using System;
using Task1_NthRoot;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            string flag;
            do
            {

                Console.WriteLine("Введите число и степень корня");
                double number = Convert.ToDouble(Console.ReadLine());
                double power = Convert.ToDouble(Console.ReadLine());
                NthRoot.CalculateRoot(number, power);
                Console.WriteLine("Результат");
                Console.WriteLine(NthRoot.result);
                Console.WriteLine("Разница между результатами (методом ньютона и встроенной функцией)");
                Console.WriteLine(NthRoot.CompareWithPow());
                Console.WriteLine("\nЧтобы повторить введите 1, чтобы закончить - любое значение");
                flag = Console.ReadLine();

            } while (flag == "1");
        }
    }
}
