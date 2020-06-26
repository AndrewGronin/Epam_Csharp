using System;

namespace Task2NOD
{
    class Program
    {
        static void Main(string[] args)
        {
            string flag;
            do
            {
                Console.WriteLine("Введите количество чисел для поиска НОД (от 2 до 5)");
                int num = Convert.ToInt32( Console.ReadLine());

                if (num < 2 && num > 5)
                {
                    Console.WriteLine("Число должно быть от 2 до 5");


                }
                else
                {
                    switch (num)
                    {
                        case 2:
                            {
                                Console.WriteLine("Введите 2 числа");
                                int a = Convert.ToInt32(Console.ReadLine());
                                int b = Convert.ToInt32(Console.ReadLine());

                                if (a < 0 || b < 0)
                                {
                                    Console.WriteLine("Числа для метода Стейна должны быть положительными");
                                }
                                else
                                {
                                    TimeSpan ts1,ts2;
                                    Console.WriteLine("НОД: " + NOD.GetNODWithTime(a, b, out ts1));
                                    Console.WriteLine("НОД алгоритмом Стэйна: " + NOD.GetNODBinaryWithTime(a, b, out ts2));

                                    string elapsedTime1 = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
                                    ts1.Hours, ts1.Minutes, ts1.Seconds,
                                    ts1.Milliseconds / 10);
                                    Console.WriteLine("RunTime " + elapsedTime1);
                                    string elapsedTime2 = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
                                    ts2.Hours, ts2.Minutes, ts2.Seconds,
                                    ts2.Milliseconds / 10);
                                    Console.WriteLine("RunTime " + elapsedTime2);
                                }
                                break;
                            }
                        case 3:
                            {
                                Console.WriteLine("Введите 3 числа");
                                int a = Convert.ToInt32(Console.ReadLine());
                                int b = Convert.ToInt32(Console.ReadLine());
                                int c = Convert.ToInt32(Console.ReadLine());

                                
                                Console.WriteLine("НОД: " + NOD.GetNOD(a, b,c));
                                
                                break;
                            }
                        case 4:
                            {
                                Console.WriteLine("Введите 4 числа");
                                int a = Convert.ToInt32(Console.ReadLine());
                                int b = Convert.ToInt32(Console.ReadLine());
                                int c = Convert.ToInt32(Console.ReadLine());
                                int d = Convert.ToInt32(Console.ReadLine());

                                Console.WriteLine("НОД: " + NOD.GetNOD(a, b, c, d));
                                break;
                            }
                        case 5:
                            {
                                Console.WriteLine("Введите 5 числа");
                                int a = Convert.ToInt32(Console.ReadLine());
                                int b = Convert.ToInt32(Console.ReadLine());
                                int c = Convert.ToInt32(Console.ReadLine());
                                int d = Convert.ToInt32(Console.ReadLine());
                                int e = Convert.ToInt32(Console.ReadLine());

                                
                                Console.WriteLine("НОД: "+NOD.GetNOD(a, b, c, d, e));
                                break;
                            }

                    }
                }



                Console.WriteLine("\nЧтобы повторить введите 1, чтобы закончить - любое значение");
                flag = Console.ReadLine();

            } while (flag == "1");

            
        }
    }
}
