using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Text;

namespace ServiceWriterFactory
{
    //The Service focused version of our Configuration Provider. This is what would be used in production and read the appsettings.json.
    public class ConfigurationProviderServices : ConfigurationProviderBase
    {
        public ConfigurationProviderServices()
        {
            //Create a new ConfigurationBuilder instance
            var configurationBuilder = new ConfigurationBuilder();
            //Add our local appsettings.json to the builder
            configurationBuilder.AddJsonFile("appsettings.json");
            //Set up our inherited _configurationRoot interface
            _configurationRoot = configurationBuilder.Build();
        }
    }
}
