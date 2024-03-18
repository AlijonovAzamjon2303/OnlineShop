//----------------------------------------
// Tarteeb School (c) All rights reserved
//----------------------------------------

using OnlineShop.Services.Shop;
using System;

namespace OnlineShop.Models.Delivery
{
    internal interface Ishipping
    {
        string Name { get; }
        double GetCost(IShop shop);
        DateTime GetDate(IShop shop);
    }
}
