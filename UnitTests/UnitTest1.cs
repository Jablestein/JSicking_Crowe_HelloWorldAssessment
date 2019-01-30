using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.Extensions.Configuration;
using APIs;
using System.Collections.Generic;
using ServiceLibrary.Services;
using System;

namespace UnitTests
{
    [TestClass]
    public class UnitTest1
    {
        private const string appSettingSection = "appSettings";

        [TestMethod]
        public void ServiceFactory_CreateService_GivenValidServiceConfiguration_CreatesValidServiceAPI()
        {

            ServiceAPI service = new ServiceAPI(new ConfigurationProviderTests("ServiceType", "ServiceLibrary.Services.ConsoleService, ServiceLibrary, Version=1.0.0.0, Culture=neutral"));

            Assert.IsNotNull(service);
            Assert.IsTrue(service.GetType() == typeof(ServiceAPI));
        }

        [TestMethod]
        public void ServiceFactory_CreateService_GivenInvalidServiceConfiguration_Throwsxception()
        {
            try
            {
                ServiceAPI service = new ServiceAPI(new ConfigurationProviderTests("ServiceType", "baddata"));
                Assert.Fail();
            }
            catch(Exception)
            {

            }
        }
    }
}
