using System;
using System.Collections.Generic;

namespace ConfigurationLoaderApp
{
    public class Configuration
    {
        public Dictionary<string, string> Settings { get; set; } = new();
    }

    public interface IConfigurationSource
    {
        bool TryLoad(out Configuration configuration);
    }

    public class EnvironmentVariableSource : IConfigurationSource
    {
        public bool TryLoad(out Configuration configuration)
        {
            configuration = null;
            return false;
        }
    }

    public class JsonFileSource : IConfigurationSource
    {
        public bool TryLoad(out Configuration configuration)
        {
            configuration = null;
            return false;
        }
    }

    public class DatabaseSource : IConfigurationSource
    {
        public bool TryLoad(out Configuration configuration)
        {
            configuration = new Configuration();
            configuration.Settings.Add("Server", "SQL01");
            configuration.Settings.Add("Database", "EmployeeDB");
            return true;
        }
    }

    public static class ConfigurationLoader
    {
        public static Configuration Load(params IConfigurationSource[] sources)
        {
            foreach (var source in sources)
            {
                if (source.TryLoad(out Configuration config))
                {
                    Console.WriteLine($"Loaded from {source.GetType().Name}");
                    return config;
                }
            }

            Console.WriteLine("No configuration loaded.");
            return null;
        }
    }

    class Program
    {
        static void Main()
        {
            Configuration config = ConfigurationLoader.Load(
                new EnvironmentVariableSource(),
                new JsonFileSource(),
                new DatabaseSource());

            if (config != null)
            {
                foreach (var item in config.Settings)
                {
                    Console.WriteLine($"{item.Key} : {item.Value}");
                }
            }
        }
    }
}