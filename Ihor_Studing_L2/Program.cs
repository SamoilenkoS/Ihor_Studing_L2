using System;

namespace Ihor_Studing_L2
{
    class Program
    {
        static double Task1(double A, double B) // A and B
        {
            return (5 * A + B * B) / (B - A);
        }

        static void Task2(ref string a, ref string b) // Changing string
        {
            string temp = a;
            a = b;
            b = temp;
        }

        static (int, int) Task3(int a, int b) // Remainder
        {
            return (a / b, a % b);
        }

        static double Task4(double a, double b, double c) // Not equal to 0
        {
            double result = 0;
            if(a != 0)
            {
                result = (c - b) / a;
            }

            return result;
        }

        static (double, double) Task5(double x1, double y1, double x2, double y2)
        {
            double a = (y1 - y2) / (x1 - x2);
            double b = y2 - a * x2;

            return (a, b);
        }

        static void Main()
        {// >, <, ==, >=, <=, !=
            //a > 0 ? 10 : -10;//(condition)? ifTrue : ifFalse ;
            double a = Convert.ToDouble(Console.ReadLine());
            double b = Convert.ToDouble(Console.ReadLine());
            double c = Convert.ToDouble(Console.ReadLine());
            if(a != 0)
            {
                double d = b * b - 4 * a * c;
                if (d > 0)
                {
                    double x1 = (-b + Math.Sqrt(d)) / (2 * a);
                    double x2 = (-b - Math.Sqrt(d)) / (2 * a);

                    Console.WriteLine($"{x1}{Environment.NewLine}{x2}");
                }
                else if (d == 0)
                {
                    double x1 = -b / (2 * a);
                    Console.WriteLine($"{x1}");
                }
                else
                {
                    Console.WriteLine("No roots");
                }
            }
        }
    }
}