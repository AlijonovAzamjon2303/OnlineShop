//----------------------------------------
// Tarteeb School (c) All rights reserved
//----------------------------------------

using System;
using OnlineShop.Models.Order;

namespace OnlineShop.Models.Delivery
{
    internal interface Ishipping
    {
        public string Name { get; set; }
        public double GetCost(IOrder order);
        public DateTime GetDate(IOrder order);
    }
}
