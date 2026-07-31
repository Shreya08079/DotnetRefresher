using System;
namespace Volume_Calculator
{
    public class Program
    {
        public static void Main(string[] args)
        {
            double length, width, height;

            Console.Write("Enter Length: ");
            if (!double.TryParse(Console.ReadLine(), out length) || length <= 0)
            {
                Console.WriteLine("Invalid length!");
                return;
            }

            Console.Write("Enter Width: ");
            if (!double.TryParse(Console.ReadLine(), out width) || width <= 0)
            {
                Console.WriteLine("Invalid width!");
                return;
            }

            Console.Write("Enter Height: ");
            if (!double.TryParse(Console.ReadLine(), out height) || height <= 0)
            {
                Console.WriteLine("Invalid height!");
                return;
            }

            double volume = length * width * height;
            Console.WriteLine($"Volume: {volume}");
        }
    }
}
