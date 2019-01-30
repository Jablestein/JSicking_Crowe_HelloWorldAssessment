using System;
using System.Reflection;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ServiceAPI;

namespace UnitTestProject2
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {

            //Configuration configuration = ConfigurationManager.OpenExeConfiguration(@"UnitTests.dll");
            //var configLocation = Assembly.GetEntryAssembly().Location;
            ServiceAPI.ServiceAPI service = new ServiceAPI.ServiceAPI();

            Assert.IsNotNull(service);
        }
    }
}
