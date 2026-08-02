namespace Question16
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string[] tokens = {"23","hgf","44" , "not" , "11"}; //Input string array
            int result = SumOfNumber(tokens);  //calling the funtion to calculate the sum of all the integer present in token array
            Console.WriteLine($"Sum of valid numbers present in Token string array is : {result}");
        }

        //Static helper method to calculate sum
        public static int SumOfNumber(string[] tokens)
        {
            int sum=0;
            foreach(string token in tokens)
            {
                if(int.TryParse(token,out int value))  //Check : only adding those who can be converted into int.
                    sum+=value;
            }
            return sum;
        }
    }
}