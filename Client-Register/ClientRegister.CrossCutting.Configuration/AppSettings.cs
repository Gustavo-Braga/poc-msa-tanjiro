using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ClientRegister.CrossCutting.Configuration
{
    public static class AppSettings
    {
        private static IConfigurationRoot _content = null;
        public static IConfigurationRoot Settings
        {
            get
            {
                if (_content == null)
                {
                    _content = new ConfigurationBuilder()
                        .SetBasePath(Directory.GetCurrentDirectory())
                        .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
                        .AddEnvironmentVariables()
                        .Build();
                }
                return _content;
            }
            private set { }
        }

        public static string GetValue(string value)
        {
            var section = Settings.GetSection(value);
            return section.Value;
        }
    }
}
