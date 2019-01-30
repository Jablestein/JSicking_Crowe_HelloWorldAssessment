using ServiceLibrary.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ServiceLibrary.Services
{
    public class HelloWorldMessage : IMessage
    {
        public string GetMessage { get { return "HelloWorld"; } }
    }
}
