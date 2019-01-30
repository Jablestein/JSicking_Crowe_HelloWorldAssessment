using ServiceLibrary.Interfaces;
using ServiceWriterFactory;

namespace APIs
{
    //Our very simple example of a Service API
    public class ServiceAPI
    {
        //The Interface for the Hello World Service who's Write Message Function we're going to call
        private IHelloWorld _helloWorldService;

        //Keeping an instance of the specific Configuration Provider we take in. In this example we could get away with not having it since it's
        //not really being utilized anywhere else right now.
        private ConfigurationProviderBase _configurationProviderBase;

        //Constructor that takes in any ConfigurationProviderBase and creates the 
        public ServiceAPI(ConfigurationProviderBase configurationProvider)
        {
            _configurationProviderBase = configurationProvider;
            _helloWorldService = ServiceFactory.CreateService(_configurationProviderBase);
            //ServiceWriter = ServiceFactory.ServiceFactory.CreateOtherService();
        }

        public void PrintHelloWorld()
        {
            _helloWorldService.WriteMessage();
        }

        //public void PrintOtherHelloWorld()
        //{
        //    ServiceWriter.WriteMessage();
        //}
    }
}
