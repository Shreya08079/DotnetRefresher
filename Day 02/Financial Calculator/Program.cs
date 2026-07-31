using System;

namespace Financial_Calculator
{
    /// <summary>
    /// Provides methods to calculate compound interest.
    /// </summary>
    public static class FinancialCalculator
    {
        /// <summary>
        /// Calculates compound interest with annual compounding.
        /// </summary>
        public static double CalculateCompoundInterest(double principal, double rate, int time)
        {
            return CalculateCompoundInterest(principal, rate, time, 1);
        }

        /// <summary>
        /// Calculates compound interest with custom compounding frequency.
        /// </summary>
        public static double CalculateCompoundInterest(double principal,
                                                       double rate,
                                                       int time,
                                                       int compoundingFrequency = 1)
        {
            return principal *
                   Math.Pow((1 + rate / compoundingFrequency),
                            compoundingFrequency * time);
        }
    }

    class Program
    {
        static void Main()
        {
            double annual = FinancialCalculator.CalculateCompoundInterest(
                10000,
                0.05,
                10);

            double monthly = FinancialCalculator.CalculateCompoundInterest(
                principal: 10000,
                rate: 0.05,
                time: 10,
                compoundingFrequency: 12);

            Console.WriteLine("Annual Compounding");
            Console.WriteLine($"Future Value : {annual:F2}");

            Console.WriteLine();

            Console.WriteLine("Monthly Compounding");
            Console.WriteLine($"Future Value : {monthly:F2}");
        }
    }
}