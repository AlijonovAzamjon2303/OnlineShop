//----------------------------------------
// Tarteeb School (c) All rights reserved
//----------------------------------------

using OnlineShop.Models.Products;
using OnlineShop.Services.Shop;
using System;

namespace OnlineShop.Models.Delivery
{
    internal class Ground : Ishipping
    {
        public string Name { get ; }
        public Ground()
        {
            this.Name = "Ground";
        }
        public double GetCost(IShop shop)
        {
            double price = 0;
            foreach (var product in shop.GetProducts())
            {
                price += product.Price * product.Weight;
            }

            return price * 1.2;
        }

        public DateTime GetDate(IShop shop)
        {
            return DateTime.Now.AddDays(7);
        }
    }
}
