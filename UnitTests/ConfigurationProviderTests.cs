using Microsoft.Extensions.Configuration;
using ServiceWriterFactory;
using System.Collections.Generic;

namespace UnitTests
{
    //The test version of our ConfigurationProvider that's used explicitly for testing.
    class ConfigurationProviderTests : ConfigurationProviderBase
    {
        //This version of the ConfigurationProvider creates hardcoded data we add to the builder so we can test different 
        //types of services quickly.
        public ConfigurationProviderTests(string key, string value)
        {
            var builder = new ConfigurationBuilder();
            var initialData = new Dictionary<string, string>
            {
                { key, value }
            };

            builder.AddInMemoryCollection(initialData);

            _configurationRoot = builder.Build();
        }
    }
}
