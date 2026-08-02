namespace Question7
{
    public class Program
    {
        public static void Main(string[] args)
        {
            if(!int.TryParse(Console.ReadLine(),out int HeightCm))  //Taking input
                Console.WriteLine("enter Valid Height");
            
            //Checking Height Category
            if(HeightCm<150)
                Console.WriteLine("Short");
            else if(HeightCm>=150 && HeightCm<180)
                Console.WriteLine("Average");
            else if(HeightCm>=180)
                Console.WriteLine("tall");
        }
    }
}