namespace Question6
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string? input = Console.ReadLine(); //Input

            //Checking for null input
            if (string.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("Error:InvalidExpression");
                return;
            }

            //Spliting the string input into valid parts
            string[] parts = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);

            if (parts.Length != 3)  //Must equal to 3 tokens : num1 , operation, num2
            {
                Console.WriteLine("Error:InvalidExpression");
                return;
            }

            if (!int.TryParse(parts[0], out int a) || !int.TryParse(parts[2], out int b))
            {
                Console.WriteLine("Error:InvalidNumber");
                return;
            }

            string op = parts[1];

            switch (op)
            {
                case "+":
                    Console.WriteLine((a + b).ToString());
                    break;

                case "-":
                    Console.WriteLine((a - b).ToString());
                    break;

                case "*":
                    Console.WriteLine((a * b).ToString());
                    break;

                case "/":
                    if (b == 0)
                    {
                        Console.WriteLine("Error:DivideByZero");
                    }
                    else
                    {
                        Console.WriteLine((a / b).ToString());
                    }
                    break;

                default:
                    Console.WriteLine("Error:UnknownOperator");
                    break;
            }
        }
    }
}
