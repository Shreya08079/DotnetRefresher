using System;
namespace Hospital_Refresher_System
{
    class Patient
    {
        public int Age;
        public double Weight;
        public double Height;
        public double Temperature;

        public double BMI()
        {
            return Weight / (Height * Height);
        }
    }

    class Validator
    {
        public static double ReadPositiveDouble(string message)
        {
            while (true)
            {
                Console.Write(message);

                if (double.TryParse(Console.ReadLine(), out double value) && value > 0)
                    return value;

                Console.WriteLine("Invalid Input. Try Again.");
            }
        }

        public static int ReadPositiveInt(string message)
        {
            while (true)
            {
                Console.Write(message);

                if (int.TryParse(Console.ReadLine(), out int value) && value > 0)
                    return value;

                Console.WriteLine("Invalid Input. Try Again.");
            }
        }
    }

    class Program
    {
        static void Main()
        {
            Patient p = new Patient();

            p.Age = Validator.ReadPositiveInt("Age: ");
            p.Weight = Validator.ReadPositiveDouble("Weight (kg): ");
            p.Height = Validator.ReadPositiveDouble("Height (m): ");
            p.Temperature = Validator.ReadPositiveDouble("Temperature (°C): ");

            Console.WriteLine("\nPatient Summary");
            Console.WriteLine("-----------------------");
            Console.WriteLine($"Age : {p.Age}");
            Console.WriteLine($"Weight : {p.Weight}");
            Console.WriteLine($"Height : {p.Height}");
            Console.WriteLine($"Temperature : {p.Temperature}");
            Console.WriteLine($"BMI : {Math.Round(p.BMI(), 2)}");
        }
    }
}
