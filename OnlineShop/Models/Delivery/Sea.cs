//----------------------------------------
// Tarteeb School (c) All rights reserved
//----------------------------------------

using OnlineShop.Services.Shop;
using System;

namespace OnlineShop.Models.Delivery
{
    internal class Sea : Ishipping
    {
        public string Name { get; }
        public Sea()
        {
            this.Name = "Sea";
        }
        public double GetCost(IShop shop)
        {
            double price = 0;
            foreach (var product in shop.GetProducts())
            {
                price += product.Price * product.Weight;
            }

            return price * 1.1;
        }

        public DateTime GetDate(IShop shop)
        {
            return DateTime.Now.AddDays(7);
        }
    }
}
