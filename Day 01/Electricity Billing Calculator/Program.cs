using System;
namespace Electricity_Billing_Calculator
{
    interface IBillCalculator
    {
        double CalculateBill(double units, double rate, double fixedCharges);
    }

    class ResidentialCustomer : IBillCalculator
    {
        public double CalculateBill(double units, double rate, double fixedCharges)
        {
            return (units * rate) + fixedCharges;
        }
    }

    class CommercialCustomer : IBillCalculator
    {
        public double CalculateBill(double units, double rate, double fixedCharges)
        {
            return (units * rate * 1.2) + fixedCharges;
        }
    }

    class Program
    {
        static void Main()
        {
            Console.Write("Customer Type (Residential/Commercial): ");
            string type = Console.ReadLine();

            Console.Write("Units Consumed: ");
            if (!double.TryParse(Console.ReadLine(), out double units) || units < 0)
            {
                Console.WriteLine("Invalid Units.");
                return;
            }

            Console.Write("Rate per Unit: ");
            if (!double.TryParse(Console.ReadLine(), out double rate) || rate < 0)
            {
                Console.WriteLine("Invalid Rate.");
                return;
            }

            Console.Write("Fixed Charges: ");
            if (!double.TryParse(Console.ReadLine(), out double fixedCharges) || fixedCharges < 0)
            {
                Console.WriteLine("Invalid Fixed Charges.");
                return;
            }

            IBillCalculator calculator;

            if (type.Equals("Residential", StringComparison.OrdinalIgnoreCase))
                calculator = new ResidentialCustomer();
            else if (type.Equals("Commercial", StringComparison.OrdinalIgnoreCase))
                calculator = new CommercialCustomer();
            else
            {
                Console.WriteLine("Invalid Customer Type.");
                return;
            }

            double bill = calculator.CalculateBill(units, rate, fixedCharges);
            Console.WriteLine($"Total Bill: {Math.Round(bill, 2)}");
        }
    }
}