using System;
namespace Student_Marks_Calculator
{
    public class Program
    {
        public static void Main(string[] args)
        {
            double total = 0;

            for (int i = 1; i <= 5; i++)
            {
                double mark;
                Console.Write($"Enter mark {i}: ");

                if (!double.TryParse(Console.ReadLine(), out mark) || mark < 0 || mark > 100)
                {
                    Console.WriteLine("Invalid mark!");
                    return;
                }

                total += mark;
            }

            double average = total / 5;
            double percentage = Math.Round(average, 2);

            Console.WriteLine($"Total: {total}");
            Console.WriteLine($"Average: {average}");
            Console.WriteLine($"Percentage: {percentage}%");
        }
    }
}
