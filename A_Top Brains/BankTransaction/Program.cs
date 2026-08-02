namespace Question8;
public class Program
{
    public static int FinalBalance(int initialBalance, int[] transactions)
    {
        int balance = initialBalance;

        foreach (int t in transactions)
        {
            if (t >= 0)
            {
                balance += t; 
            }
            else if (balance + t >= 0)
            {
                balance += t;
            }
        }

        return balance;
    }
    public static void Main()
    {
        int initialBalance = 1000;
        int[] transactions = { 200, -500, -800, 300 };

        int result = FinalBalance(initialBalance, transactions);
        Console.WriteLine(result);
    }
}