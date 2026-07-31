using System;
namespace Bank_Balance_Calculator
{
    public class Program
    {
        public static void Main(string[] args)
        {
            double balance, deposits, withdrawals;

            Console.Write("Enter Opening Balance: ");
            if (!double.TryParse(Console.ReadLine(), out balance) || balance < 0)
            {
                Console.WriteLine("Invalid balance!");
                return;
            }

            Console.Write("Enter Deposits: ");
            if (!double.TryParse(Console.ReadLine(), out deposits) || deposits < 0)
            {
                Console.WriteLine("Invalid deposits!");
                return;
            }

            Console.Write("Enter Withdrawals: ");
            if (!double.TryParse(Console.ReadLine(), out withdrawals) || withdrawals < 0)
            {
                Console.WriteLine("Invalid withdrawals!");
                return;
            }

            double available = balance + deposits;

            if (withdrawals > available)
            {
                Console.WriteLine("Error: Withdrawal exceeds available balance!");
                return;
            }

            double finalBalance = available - withdrawals;

            Console.WriteLine($"Final Balance: {finalBalance}");
        }
    }
    
}
