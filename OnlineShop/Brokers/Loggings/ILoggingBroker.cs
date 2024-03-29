﻿//----------------------------------------
// Tarteeb School (c) All rights reserved
//----------------------------------------

using System;

namespace OnlineShop.Brokers.Loggings
{
    internal interface ILoggingBroker
    {
        void Log(string message);
        void LogError(string message);
        void LogError(Exception exception);
    }
}
