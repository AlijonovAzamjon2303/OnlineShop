//----------------------------------------
// Tarteeb School (c) All rights reserved
//----------------------------------------

namespace OnlineShop.Models.Products
{
    internal interface IProduct
    {
        public int Id { get; set; }
        public double Price { get; set; }
        public double Weight { get; set; }
    }
}
