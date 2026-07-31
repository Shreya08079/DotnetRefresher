using System;

namespace GeometryLibrary
{
    public static class Geometry
    {
        public static double CalculateArea(double radius, int decimals = 2)
        {
            return Math.Round(Math.PI * radius * radius, decimals);
        }

        public static double CalculateArea(double length, double width)
        {
            return length * width;
        }

        public static double CalculateArea(double @base, double height, bool triangle)
        {
            return 0.5 * @base * height;
        }
    }

    class Program
    {
        static void Main()
        {
            Console.WriteLine($"Circle : {Geometry.CalculateArea(5)}");
            Console.WriteLine($"Rectangle : {Geometry.CalculateArea(4, 6)}");
            Console.WriteLine($"Triangle : {Geometry.CalculateArea(3, 7, true)}");
            Console.WriteLine($"Circle : {Geometry.CalculateArea(radius: 5, decimals: 4)}");
        }
    }
}