namespace Question3
{
    public class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                Console.Write("Enter Number Num1 : ");
                if (!int.TryParse(Console.ReadLine(), out int num1))
                    throw new Exception();

                Console.Write("Enter Number Num2 : ");
                if (!int.TryParse(Console.ReadLine(), out int num2))
                    throw new Exception();

                //Swaping by reference :
                SwapByRef(ref num1, ref num2);
                Console.WriteLine($"Using SwapByRef\nNum1 : {num1}  Num2 : {num2}");

                // Reset values for demonstration
                int a = num1;
                int b = num2;
                
                //Swaping by Value :(Original Value won't change)
                SwapByOut(a,b,out num1,out num2);
                Console.WriteLine($"Using SwapByOut\nNum1 : {num1}  Num2 : {num2}");
                
            }
            catch (Exception)
            {
                Console.WriteLine("Enter Valid input.");
            }

        }

        public static void SwapByOut(int a, int b, out int num1, out int num2)
        {
            num1 = b; // MUST assign
            num2 = a; // MUST assign
        }
        public static void SwapByRef(ref int num1, ref int num2)
        {
            
            num1=num1+num2;
            num2=num1 - num2;
            num1 = num1-num2;   
        }
    }
}