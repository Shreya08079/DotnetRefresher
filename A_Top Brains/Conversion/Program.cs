namespace Question18
{
    public class Program
    {
        public static void Main(string[] args)
        {
            if(!Decimal.TryParse(Console.ReadLine(),out decimal foot))  //taking valid input of decimal
                Console.WriteLine("Enter valid Input for Foot.");
            
            decimal cm = foot * 30.48m; //foot to cm conversion
            decimal roundOffCm =  Math.Round(cm, 2, MidpointRounding.AwayFromZero); //rounding off to 2 decimal place
            Console.WriteLine($"{foot} Foot = {roundOffCm} cm");
        }
    }
}