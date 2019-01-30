using ServiceLibrary.Interfaces;
using System;

namespace ServiceLibrary.Services
{
    public class ConsoleService : IHelloWorld
    {
        public void WriteMessage()
        {
            Console.WriteLine("Hello World");
        }
    }
}
