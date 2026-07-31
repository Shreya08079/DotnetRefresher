using System;

namespace LoggingSystem
{
    static class Logger
    {
        public static string FormatLogMessage(string template, params object[] args)
        {
            string result = template;

            void ReplacePlaceholders()
            {
                for (int i = 0; i < args.Length; i++)
                {
                    string value;

                    if (args[i] is DateTime dt)
                        value = dt.ToString("yyyy-MM-dd HH:mm:ss");
                    else
                        value = args[i].ToString();

                    result = result.Replace("{" + i + "}", value);
                }
            }

            ReplacePlaceholders();

            return result;
        }
    }

    class Program
    {
        static void Main()
        {
            string message = Logger.FormatLogMessage(
                "User {0} logged in from {1} at {2}",
                "JohnDoe",
                "192.168.1.1",
                DateTime.Now);

            Console.WriteLine(message);
        }
    }
}