// See https://aka.ms/new-console-template for more information
using System;

namespace ProblemSet
{
    class Question5
    {
        static void Main(string[] args)
        {
            Double a, a1, a2, b, b1, b2;

            Console.WriteLine("Enter the point, lower left and upper right corner of the rectangle: ");
            a = Convert.ToDouble(Console.ReadLine());
            b = Convert.ToDouble(Console.ReadLine());
            a1 = Convert.ToDouble(Console.ReadLine());
            b1 = Convert.ToDouble(Console.ReadLine());
            a2 = Convert.ToDouble(Console.ReadLine());
            b2 = Convert.ToDouble(Console.ReadLine());

            bool decision = Inside(a, b, a1, b1, a2, b2);

            Console.WriteLine(decision);
            Console.ReadLine();
        }

        static bool Inside(Double x, Double y, Double x1, Double y1, Double x2, Double y2)
        {
            if (x > x1 && x < x2 && y > y1 && y < y2)
                return true;
            else
                return false;
        }

    }
}
