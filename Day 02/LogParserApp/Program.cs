using System;

namespace LogParserApp
{
    public enum LogLevel
    {
        Info,
        Warning,
        Error
    }

    public static class LogParser
    {
        public static bool ParseLogLine(in string logLine,
                                        out DateTime timestamp,
                                        out LogLevel level,
                                        ref int counter)
        {
            timestamp = DateTime.MinValue;
            level = LogLevel.Info;

            counter++;

            string[] parts = logLine.Split(' ');

            if (parts.Length < 3)
                return false;

            if (!DateTime.TryParse(parts[0] + " " + parts[1], out timestamp))
                return false;

            if (parts[2].StartsWith("ERROR"))
                level = LogLevel.Error;
            else if (parts[2].StartsWith("WARNING"))
                level = LogLevel.Warning;
            else
                level = LogLevel.Info;

            return true;
        }
    }

    class Program
    {
        static void Main()
        {
            int counter = 0;

            string log = "2023-10-27 14:30:00 ERROR: Disk full";

            if (LogParser.ParseLogLine(
                in log,
                out DateTime time,
                out LogLevel level,
                ref counter))
            {
                Console.WriteLine($"Timestamp : {time}");
                Console.WriteLine($"Level : {level}");
                Console.WriteLine($"Counter : {counter}");
            }
        }
    }
}