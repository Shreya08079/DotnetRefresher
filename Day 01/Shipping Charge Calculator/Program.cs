using System;
namespace Shipping_Charge_Calculator
{
    interface IShippingCalculator
    {
        double Calculate(double weight, double distance);
    }

    class StandardPackage : IShippingCalculator
    {
        public double Calculate(double weight, double distance)
        {
            return weight * distance * 0.5;
        }
    }

    class ExpressPackage : IShippingCalculator
    {
        public double Calculate(double weight, double distance)
        {
            return weight * distance * 0.8 + 100;
        }
    }

    class Program
    {
        static void Main()
        {
            Console.Write("Package Type (Standard/Express): ");
            string type = Console.ReadLine();

            Console.Write("Weight (kg): ");
            if (!double.TryParse(Console.ReadLine(), out double weight) || weight <= 0 || weight > 1000)
            {
                Console.WriteLine("Invalid Weight.");
                return;
            }

            Console.Write("Distance (km): ");
            if (!double.TryParse(Console.ReadLine(), out double distance) || distance <= 0 || distance > 10000)
            {
                Console.WriteLine("Invalid Distance.");
                return;
            }

            IShippingCalculator shipping;

            if (type.Equals("Standard", StringComparison.OrdinalIgnoreCase))
                shipping = new StandardPackage();
            else if (type.Equals("Express", StringComparison.OrdinalIgnoreCase))
                shipping = new ExpressPackage();
            else
            {
                Console.WriteLine("Invalid Package Type.");
                return;
            }

            Console.WriteLine($"Shipping Cost : {Math.Round(shipping.Calculate(weight, distance), 2)}");
        }
    }
}
