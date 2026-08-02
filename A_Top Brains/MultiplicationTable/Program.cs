namespace Question2
{
    public class Program
    {
        public static void Main()
        {
            try
            {
                Console.Write("Enter Number N : "); //input for number
                if (!int.TryParse(Console.ReadLine(), out int n))   //making sure string is converted into int or not
                    throw new Exception("Invalid input for N");

                Console.Write("Enter Number Upto : ");  //input for upto
                if (!int.TryParse(Console.ReadLine(), out int upto)  || upto<=0)    //checking edge cases
                    throw new Exception("Invalid input for Upto");

                int[] multiplicationRow = Multiplication(n, upto);

                foreach (int item in multiplicationRow)
                {
                    Console.Write(item + " ");
                }
            }
            catch (Exception ecp)
            {
                Console.WriteLine($"Error Message : {ecp.Message}");
            }

        }

        //Helper static method to return the multiplication row
        public static int[] Multiplication(int n, int upto)
        {
            int[] multiplicationRow = new int[upto];
            for (int i = 1; i <= upto; i++)
            {
                multiplicationRow[i - 1] = n * i;
            }

            return multiplicationRow;
        }
    }
}