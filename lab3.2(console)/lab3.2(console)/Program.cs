using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3._2_console_
{
    internal class Program
    {
        static double f(double x, double a, double b, double c)
        {
            double y;
            if (x < 93)
            {
                y = a + b * x;
            }
            else if (x >= 93 && x <= 120)
            {
                y = b - a * c;
            }
            else if (x > 120)
            {
                y = a * b * x;
            }
            else
            {
                Console.WriteLine("Ошибка!");
                y = 0;
            }
            return y;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Введите a");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите b");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите c");
            double c = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите h");
            double h = double.Parse(Console.ReadLine());

            if (a > b)
            {
                Console.WriteLine("Ошибка. Начало диапозона не может быть больше конца диапозона.");
            }

            for (double i = a; i <= b; i += h)
            {
                if (h <= 0)
                {
                    Console.WriteLine("Ошибка. Шаг не может быть отрицательным или равным 0. Повторите попытку.");
                    break;
                }
                else
                {
                    Console.WriteLine("f({0:f2})={1:f4}", i, f(i, a, b, c));
                }
            }
        }
    }
}