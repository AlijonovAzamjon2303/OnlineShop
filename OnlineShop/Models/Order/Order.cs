//----------------------------------------
// Tarteeb School (c) All rights reserved
//----------------------------------------

using OnlineShop.Models.Delivery;
using OnlineShop.Models.Products;
using System;

namespace OnlineShop.Models.Order
{
    internal class Order : IOrder
    {
        public int Id { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void AddItem(IProduct product)
        {
            throw new NotImplementedException();
        }

        public double GetShippingCost()
        {
            throw new NotImplementedException();
        }

        public DateTime GetShippingDate()
        {
            throw new NotImplementedException();
        }

        public double GetTotal()
        {
            throw new NotImplementedException();
        }

        public double GetTotalWeight()
        {
            throw new NotImplementedException();
        }

        public void SetShippingType(Ishipping shipping)
        {
            throw new NotImplementedException();
        }
    }
}
