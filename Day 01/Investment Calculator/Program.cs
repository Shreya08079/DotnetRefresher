using System;
namespace Investment_Calculator
{
    interface IInvestmentCalculator
    {
        double Calculate(double principal, double rate, int years);
    }

    class SimpleInterest : IInvestmentCalculator
    {
        public double Calculate(double principal, double rate, int years)
        {
            return principal + (principal * rate * years / 100);
        }
    }

    class CompoundInterest : IInvestmentCalculator
    {
        public double Calculate(double principal, double rate, int years)
        {
            return principal * Math.Pow((1 + rate / 100), years);
        }
    }

    class Program
    {
        static void Main()
        {
            Console.Write("Investment Type (Simple/Compound): ");
            string type = Console.ReadLine();

            Console.Write("Principal Amount: ");
            if (!double.TryParse(Console.ReadLine(), out double principal) || principal <= 0)
            {
                Console.WriteLine("Invalid Principal.");
                return;
            }

            Console.Write("Annual Rate (%): ");
            if (!double.TryParse(Console.ReadLine(), out double rate) || rate < 0 || rate > 100)
            {
                Console.WriteLine("Invalid Rate.");
                return;
            }

            Console.Write("Duration (Years): ");
            if (!int.TryParse(Console.ReadLine(), out int years) || years <= 0)
            {
                Console.WriteLine("Invalid Duration.");
                return;
            }

            IInvestmentCalculator calculator;

            if (type.Equals("Simple", StringComparison.OrdinalIgnoreCase))
                calculator = new SimpleInterest();
            else if (type.Equals("Compound", StringComparison.OrdinalIgnoreCase))
                calculator = new CompoundInterest();
            else
            {
                Console.WriteLine("Invalid Investment Type.");
                return;
            }

            double amount = calculator.Calculate(principal, rate, years);

            Console.WriteLine($"Projected Value : {Math.Round(amount, 2)}");
        }
    }
}
