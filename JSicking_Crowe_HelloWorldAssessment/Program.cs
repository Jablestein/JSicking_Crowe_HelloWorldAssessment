using System;
using System.IO;
using Microsoft.Extensions.Configuration;
using APIs;
using ServiceWriterFactory;

namespace JSicking_Crowe_HelloWorldAssessment
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create a new instance of the Service API and inject a Service focused Configuration Provider into it.
            ServiceAPI service = new ServiceAPI(new ConfigurationProviderServices());

            //Use the service to print Hello World.
            service.PrintHelloWorld();

            Console.WriteLine("Press Enter to Exit");
            //Wait until someone hits Enter
            Console.ReadLine();
        }
    }
}
