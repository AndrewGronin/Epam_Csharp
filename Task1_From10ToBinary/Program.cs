using System;
using Task1_From10ToBinary;

namespace Task1_From10ToBinary
{
    class Program
    {
        static void Main(string[] args)
        {

            string flag;
            do
            {
                Console.WriteLine("Введите число");
                int number = Convert.ToInt32(Console.ReadLine());

                if (number <= 0)
                {
                    Console.WriteLine("Число должно быть положителным");
                }
                else
                {
                    ConverterFrom10ToBinary.Convert1(number);
                    Console.WriteLine("Число в двоичной системе (первый метод)");
                    Console.WriteLine(ConverterFrom10ToBinary.result1);
                    ConverterFrom10ToBinary.Convert2(number);
                    Console.WriteLine("Число в двоичной системе (второй метод)");
                    Console.WriteLine(ConverterFrom10ToBinary.result2);
                }
                Console.WriteLine("\nЧтобы повторить введите 1, чтобы закончить - любое значение");
                flag = Console.ReadLine();

            } while (flag == "1");
        }
    }
}
