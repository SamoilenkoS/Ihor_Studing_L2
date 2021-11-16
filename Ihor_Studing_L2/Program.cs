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
            return (c - b) / a;
        }

        static (double, double) Task5(double x1, double y1, double x2, double y2)
        {
            double a = (y1 - y2) / (x1 - x2);
            double b = y2 - a * x2;

            return (a, b);
        }

        static void Main()
        {
        }
    }
}