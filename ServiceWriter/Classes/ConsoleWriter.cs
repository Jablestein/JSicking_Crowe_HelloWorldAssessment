using System;
using System.Collections.Generic;
using System.Text;
using ServiceLibrary.Interfaces;

namespace ServiceLibrary.Classes
{
    public class ConsoleWriter : ServiceWriter
    {
        public ConsoleWriter(IMessage message) : base(message)
        {
        }

        protected override void WriteMessageToMedium(IMessage message)
        {
            Console.WriteLine(_message.GetMessage);
        }
    }
}
