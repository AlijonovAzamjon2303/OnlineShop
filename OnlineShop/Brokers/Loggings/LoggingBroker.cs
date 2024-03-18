//----------------------------------------
// Tarteeb School (c) All rights reserved
//----------------------------------------

using System;

namespace OnlineShop.Brokers.Loggings
{
    internal class LoggingBroker : ILoggingBroker
    {
        public void Log(string message)
        {
            Console.WriteLine(message);
        }

        public void LogError(string message)
        {
            Console.WriteLine(message);
        }

        public void LogError(Exception exception)
        {
            Console.WriteLine($"Error: {exception.Message}");
        }
    }
}
