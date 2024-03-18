//----------------------------------------
// Tarteeb School (c) All rights reserved
//----------------------------------------

using OnlineShop.Models.Delivery;
using OnlineShop.Models.Products;
using System;
using System.Collections.Generic;

namespace OnlineShop.Services.Shop
{
    internal class Shop : IShop
    {
        private List<Book> products;
        private Ishipping shipping;
        public Shop()
        {
            products = new List<Book>();
            shipping = new Ground();
        }
        public Book AddProduct(Book product)
        {
            products.Add(product);
            
            return product;
        }

        public void DeleteProduct(int productId)
        {
            Book oldProduct = new Book();
            foreach (var product in this.products)
            {
                if(product.Id ==  productId)
                {
                    oldProduct = product;
                    break;
                }
            }

            this.products.Remove(oldProduct);
        }
        
        public double GetPrice()
        {
            return this.shipping.GetCost(this);
        }

        public string GetShipping()
        {
            return this.shipping.Name;
        }

        public void SetShipping(Ishipping shipping)
        {
            this.shipping = shipping;
        }

        public void ShowProducts()
        {
            foreach(var product in products)
            {
                Console.WriteLine($"{product.Id}| {product.Name}| {product.Price} * {product.Weight} = {product.Weight * product.Price}");
            }
        }

        public List<Book> GetProducts()
        {
            return this.products;
        }
    }
}
