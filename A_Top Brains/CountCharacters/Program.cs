using System.ComponentModel.DataAnnotations;

namespace Question19
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int Len=0;
            string input = Console.ReadLine() ?? string.Empty;
            foreach(char character in input)
            {
                if(character != ' ')    
                    Len++;
            }
            Console.WriteLine($"Total Characters in this string is : {Len} (Exculding white spaces)");
        }
    }
}
/* 
2nd Solution:

instead of checking white space everytime , we remove the whitespace and then count the characters.
>> string withoutSpaces = input.Replace(" ", "");
>> Now we can count the characters in withoutSpaces string and return it.

*/