//----------------------------------------
// Tarteeb School (c) All rights reserved
//----------------------------------------

namespace OnlineShop.Models.Products
{
    internal class Book : IProduct
    {
        public int Id { get; set; }
        public string Name { get; set ; }
        public double Price { get; set; }
        public double Weight { get; set; }
    }
}
