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
        Book AddProduct(Book product);
        void DeleteProduct(int productId);
        double GetPrice();
        void SetShipping(Ishipping shipping);
        string GetShipping();
        List<Book> GetProducts();
        void ShowProducts();
    }
}
