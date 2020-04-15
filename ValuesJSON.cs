using Microsoft.Extensions.Configuration;
using System.IO;

namespace ConsoleApp
{
    /// <summary>
    /// Provides static methods for reading .json files within root directory.
    /// </summary>
    static class ValuesJSON
    {
        /// <summary>
        /// Returns value from appsetings.json file.
        /// </summary>
        public static string Value(string key)
        {
            var config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile(path: "appsettings.json", optional: false, reloadOnChange: true)
                .Build();

            return $"{config[key]}";
        }
        /// <summary>
        /// Returns value from specific .json file.
        /// </summary>
        public static string Value(string jsonName, string key)
        {
            var config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile(path: jsonName, optional: false, reloadOnChange: true)
                .Build();

            return $"{config[key]}";
        }
    }
}
