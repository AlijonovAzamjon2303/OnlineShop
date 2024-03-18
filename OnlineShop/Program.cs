//----------------------------------------
// Tarteeb School (c) All rights reserved
//----------------------------------------

using OnlineShop.Brokers.Loggings;
using OnlineShop.Models.Delivery;
using OnlineShop.Models.Products;
using OnlineShop.Models.Users;
using OnlineShop.Services.Auth;
using OnlineShop.Services.Shop;
using System;
using System.Collections.Generic;

internal class Program
{
    private static void Main(string[] args)
    {
        List<IProduct> products = new List<IProduct>();
        Authorization();
    }
    static void Authorization()
    {
        LoggingBroker broker = new LoggingBroker();
        Console.WriteLine("1.Sign Up");
        Console.WriteLine("2.Log In");
        Console.WriteLine("3.Exit");
        string choice = Console.ReadLine();
        switch (choice)
        {
            case "1":
                {
                    IAuth auth = new Auth();
                    IUser user = new User();
                    Console.Write("Id = "); user.Id = int.Parse(Console.ReadLine());
                    Console.Write("Username = "); user.Username = Console.ReadLine();
                    Console.Write("Password = "); user.Password = Console.ReadLine();
                    auth.SignUp(user);

                    Shop();
                }
                break;
            case "2":
                {
                    IAuth auth = new Auth();
                    IUser user = new User();
                    Console.Write("Id = "); user.Id = int.Parse(Console.ReadLine());
                    Console.Write("Username = "); user.Username = Console.ReadLine();
                    Console.Write("Password = "); user.Password = Console.ReadLine();
                    if (!auth.LogIn(user))
                    {
                        broker.LogError("Username or password wrong!");
                        broker.LogError("Sign Up or try again");
                    }
                    else
                    {
                        Shop();
                    }
                }
                break;
            case "3":
                {
                    return;
                }
                break;
        }
    }
    static void Shop()
    {
        IShop shop = new Shop();
        string choice;
        do
        {
            Console.WriteLine("1.Add Product");
            Console.WriteLine("2.Delete Product");
            Console.WriteLine("3.Get Price");
            Console.WriteLine("4.Show Products");
            Console.WriteLine("5.Set Shipping Type");
            choice = Console.ReadLine();    
            switch(choice)
            {
                case "1":
                    {
                        IProduct product = new Book();
                        Console.Write("Id = "); product.Id = int.Parse(Console.ReadLine());
                        Console.Write("Name = "); product.Name = Console.ReadLine();
                        Console.Write("Price = "); product.Price = double.Parse(Console.ReadLine());
                        Console.Write("Weight = "); product.Weight = double.Parse(Console.ReadLine());
                        shop.AddProduct(product);
                    }
                    break;
                case "2":
                    {
                        int productId;
                        Console.Write("Id = "); productId = int.Parse(Console.ReadLine());
                        shop.DeleteProduct(productId);
                    }
                    break;
                case "3":
                    {
                        shop.ShowProducts();
                        shop.GetPrice();
                    }
                    break;
                case "4":
                        {
                        shop.ShowProducts();
                        }
                    break;
                case "5":
                    {
                        Air air = new Air();
                        Ground ground = new Ground();
                        Sea sea = new Sea();
                        Console.WriteLine("1.Air");
                        Console.WriteLine("2.Ground");
                        Console.WriteLine("3.Sea");
                    }
                    break;
            }
        } while(true);
    }
}