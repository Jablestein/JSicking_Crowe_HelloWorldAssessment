using ServiceLibrary.Interfaces;
using System;

namespace ServiceWriterFactory
{
    public static class ServiceFactory
    {
        //Our ConfigurationProviderBase that gets passed in from the ServiceAPI.
        private static ConfigurationProviderBase _configurationProvider;

        //Create our service using the proper Configuration type and use the information in that configuration to determine
        //which specific type of service it is we're going to create.
        public static IHelloWorld CreateService(ConfigurationProviderBase configurationProvider) 
        {
            //Assign the _configurationProvider
            _configurationProvider = configurationProvider;

            //Get the name of the service we want to create.
            var serviceTypeName = _configurationProvider.ConfigurationRoot.GetSection("ServiceType");

            //Create a Type to hold that Type
            Type serviceType = Type.GetType(serviceTypeName.Value);

            //So we can then use it to create an instance of the service we need.
            object service = Activator.CreateInstance(serviceType);
            
            //We should be safe to cast this back to our IHelloWorld interface and return it.
            IHelloWorld helloWorldService = service as IHelloWorld;

            return helloWorldService;
        }

        //public static ServiceWriter CreateOtherService()
        //{
        //    HelloWorldMessage helloWorldMessage = new HelloWorldMessage();
        //    string serviceTypeName = ConfigurationManager.AppSettings["ServiceType"];
        //    Type serviceType = Type.GetType(serviceTypeName);
        //    object service = Activator.CreateInstance(serviceType, helloWorldMessage);

        //    return service as ServiceWriter;
        //}
    }
}
