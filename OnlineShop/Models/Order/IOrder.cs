//----------------------------------------
// Tarteeb School (c) All rights reserved
//----------------------------------------

using System;
using OnlineShop.Models.Delivery;
using OnlineShop.Models.Products;

namespace OnlineShop.Models.Order
{
    internal interface IOrder
    {
        public int Id { get; set; }
        double GetTotal();
        double GetTotalWeight();
        void SetShippingType(Ishipping shipping);
        double GetShippingCost();
        DateTime GetShippingDate();
        void AddItem(IProduct product);
    }
}
