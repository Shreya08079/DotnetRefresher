using System;
using System.Collections.Generic;

namespace LibraryOrderApp
{
    public static class OrderProcessor
    {
        public static bool TryParseISBN(string isbn, out string cleanedISBN)
        {
            cleanedISBN = isbn.Replace("-", "").Replace(" ", "");

            if (cleanedISBN.Length == 13 && long.TryParse(cleanedISBN, out _))
                return true;

            cleanedISBN = string.Empty;
            return false;
        }

        public static bool TryProcessOrder(out List<string> validISBNs, params string[] isbns)
        {
            validISBNs = new List<string>();

            foreach (string isbn in isbns)
            {
                if (TryParseISBN(isbn, out string cleaned))
                {
                    validISBNs.Add(cleaned);
                }
            }

            return validISBNs.Count > 0;
        }
    }

    class Program
    {
        static void Main()
        {
            bool result = OrderProcessor.TryProcessOrder(
                out List<string> books,
                "978-3-16-148410-0",
                "1234567890123",
                "invalid-isbn",
                "978-1-4028-9462-6"
            );

            Console.WriteLine($"Result: {result}");

            Console.WriteLine("Valid ISBNs:");

            foreach (string isbn in books)
            {
                Console.WriteLine(isbn);
            }
        }
    }
}