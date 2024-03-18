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
        private List<IProduct> products;
        private Ishipping shipping;
        public Shop()
        {
            products = new List<IProduct>();
            shipping = new Ground();
        }
        public IProduct AddProduct(IProduct product)
        {
            products.Add(product);
            
            return product;
        }

        public void DeleteProduct(int productId)
        {
            IProduct oldProduct = new Book();
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

        public List<IProduct> GetProducts()
        {
            return this.products;
        }
    }
}
