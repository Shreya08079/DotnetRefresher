using System;
using System.Text;
using System.Globalization;

public class InventoryNameCleanup
{
    public static void Main(string[] args)
    {
        string input = " llapppptop bag ";

        string cleaned = CleanProductName(input);

        Console.WriteLine(cleaned);
    }

    static string CleanProductName(string input)
    {
        // Step 1: Trim spaces
        string trimmed = input.Trim();

        // Step 2: Remove consecutive duplicate characters
        StringBuilder sb = new StringBuilder();
        sb.Append(trimmed[0]);

        for (int i = 1; i < trimmed.Length; i++)
        {
            if (trimmed[i] != trimmed[i - 1])
            {
                sb.Append(trimmed[i]);
            }
        }

        // Step 3: Convert to Title Case
        TextInfo textInfo = CultureInfo.CurrentCulture.TextInfo;
        string titleCase = textInfo.ToTitleCase(sb.ToString().ToLower());

        return titleCase;
    }
}
