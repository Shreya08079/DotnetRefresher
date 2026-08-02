using System;
using System.Text;

public class MahirlAndAlphabets
{
    public static void Main(string[] args)
    {
        string? firstWord = Console.ReadLine();
        string? secondWord = Console.ReadLine();

        string? resultAfterConsonantRemoval = RemoveCommonConsonants(firstWord, secondWord);
        string? finalResult = RemoveConsecutiveDuplicates(resultAfterConsonantRemoval);

        Console.WriteLine(finalResult);
    }

    static string RemoveCommonConsonants(string first, string second)
    {
        StringBuilder result = new StringBuilder();
        string secondLower = second.ToLower();

        foreach (char ch in first)
        {
            char lowerChar = char.ToLower(ch);

            if (IsVowel(lowerChar))
            {
                result.Append(ch);
            }
            else
            {
                if (!secondLower.Contains(lowerChar))
                {
                    result.Append(ch);
                }
            }
        }

        return result.ToString();
    }

    static string RemoveConsecutiveDuplicates(string input)
    {
        if (input.Length == 0)
            return input;

        StringBuilder result = new StringBuilder();
        result.Append(input[0]);

        for (int i = 1; i < input.Length; i++)
        {
            if (input[i] != input[i - 1])
            {
                result.Append(input[i]);
            }
        }

        return result.ToString();
    }

    static bool IsVowel(char ch)
    {
        return ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u';
    }
}
