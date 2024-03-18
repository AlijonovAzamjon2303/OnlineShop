//----------------------------------------
// Tarteeb School (c) All rights reserved
//----------------------------------------

using OnlineShop.Models.Delivery;
using OnlineShop.Models.Products;
using System.Collections.Generic;

namespace OnlineShop.Services.Shop
{
    internal interface IShop
    {
        IProduct AddProduct(IProduct product);
        void DeleteProduct(int productId);
        double GetPrice();
        void SetShipping(Ishipping shipping);
        string GetShipping();
        void ShowProducts();
    }
}
