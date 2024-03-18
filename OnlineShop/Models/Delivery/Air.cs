//----------------------------------------
// Tarteeb School (c) All rights reserved
//----------------------------------------

using OnlineShop.Models.Products;
using OnlineShop.Services.Shop;
using System;
using System.Collections.Generic;

namespace OnlineShop.Models.Delivery
{
    internal class Air : Ishipping
    {
        public string Name { get; }
        public Air()
        {
            this.Name = "Air";
        }
        public double GetCost(IShop shop)
        {
            double price = 0;
            foreach (var product in shop.GetProducts())
            {
                price += product.Price * product.Weight;
            }

            return price * 1.3;
        }

        public DateTime GetDate(IShop shop)
        {
            return DateTime.Now.AddDays(7);
        }
    }
}
