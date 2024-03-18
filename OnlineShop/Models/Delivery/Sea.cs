//----------------------------------------
// Tarteeb School (c) All rights reserved
//----------------------------------------

using OnlineShop.Services.Shop;
using System;

namespace OnlineShop.Models.Delivery
{
    internal class Sea : Ishipping
    {
        public string Name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public double GetCost(IShop shop)
        {
            throw new NotImplementedException();
        }

        public DateTime GetDate(IShop shop)
        {
            throw new NotImplementedException();
        }
    }
}
