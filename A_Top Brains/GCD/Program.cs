using System;
public class GCD
{
    public static int Gcd(int num1, int num2)
    {
        while(num2 != 0)
        {
            int rem = num1 % num2;
            num1 = num2;
            num2 = rem;
        }
        return num1;
    }
    public static void Main()
    {
        if(!int.TryParse(Console.ReadLine(),out int  a) || !int.TryParse(Console.ReadLine(),out int b)){
            Console.WriteLine("Enter Valid Numbers.");
            return;
        }
        Console.WriteLine($"GCD is of this Two Num is {a} and {b} : {Gcd(a,b)}");
    }
}