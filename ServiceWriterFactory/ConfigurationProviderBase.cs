using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Text;

namespace ServiceWriterFactory
{
    //Our base ConfigurationProvider class that we'll derive all other Configuration Providers from.
    public abstract class ConfigurationProviderBase
    {
        protected IConfigurationRoot _configurationRoot;
        public IConfigurationRoot ConfigurationRoot { get { return _configurationRoot; } }
    }
}
