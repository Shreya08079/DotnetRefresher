using System.Diagnostics.CodeAnalysis;
using System.Runtime.InteropServices;

namespace Question12
{
    public class Program
    {
        public static void Main(string[] args)
        {
            
            int[] arr = {1,-2,5,9,-34,0,33,-12};
            Console.WriteLine($"Sum : {SumOfPositiveInteger(arr)}");
            
        }

        public static int SumOfPositiveInteger(int[] arr)
        {
            int sum=0;
            foreach(int it in arr)
            {
                if (it > 0)
                {
                    sum+=it;
                }else if(it == 0)
                {
                    break;
                }
            }
            return sum;
        }

    }
}