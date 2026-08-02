namespace Question6
{
    public class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                Console.Write("Enter Number Num1 : "); //input for Num1
                if (!int.TryParse(Console.ReadLine(), out int num1))   //making sure string is converted into int or not
                    throw new Exception("Invalid input for N");

                Console.Write("Enter Number Num2 : ");  //input for Num2
                if (!int.TryParse(Console.ReadLine(), out int num2))
                    throw new Exception("Invalid input for num2");

                Console.Write("Enter Number Num3 : ");  //input for Num2
                if (!int.TryParse(Console.ReadLine(), out int num3))
                    throw new Exception("Invalid input for num3");

                int result = GetLargestNumber(num1, num2, num3);    //Checking for result by calling helper function
                Console.WriteLine($"Largest Integer amount these numbers is : {result}");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        
        //static helper method which returns the largest number amoung 3 numbers.
        public static int GetLargestNumber(int a, int b, int c)
        {
            if (a >= b && a >= c)
                return a;
            else if (b >= a && b >= c)
                return b;
            else
                return c;
        }
    }
}