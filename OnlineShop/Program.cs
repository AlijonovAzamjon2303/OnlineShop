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

internal class Program
{
    private static void Main(string[] args)
    {
        Authorization();
    }
    static void Authorization()
    {
        Console.Clear();
        LoggingBroker broker = new LoggingBroker();
        Console.WriteLine("1.Sign Up");
        Console.WriteLine("2.Log In");
        Console.WriteLine("3.Exit");
        string choice = Console.ReadLine();
        switch (choice)
        {
            case "1":
                {
                    Console.Clear();
                    IAuth auth = new Auth();
                    User user = new User();
                    Console.Write("Id = "); user.Id = int.Parse(Console.ReadLine());
                    Console.Write("Username = "); user.Username = Console.ReadLine();
                    Console.Write("Password = "); user.Password = Console.ReadLine();
                    auth.SignUp(user);
                    if (user.Id == -1)
                    {
                        Console.WriteLine("You already login");
                    }
                    Shop();
                }
                break;
            case "2":
                {
                    Console.Clear();
                    IAuth auth = new Auth();
                    User user = new User();
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
                    Console.Clear();
                    Console.WriteLine("The Program has been ended");
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
            Console.WriteLine("3.Set Shipping Type");
            Console.WriteLine("4.Finish program");
            choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    {
                        Console.Clear();
                        Book product = new Book();
                        Console.Write("Id = "); product.Id = int.Parse(Console.ReadLine());
                        Console.Write("Name = "); product.Name = Console.ReadLine();
                        Console.Write("Price = "); product.Price = double.Parse(Console.ReadLine());
                        Console.Write("Weight = "); product.Weight = double.Parse(Console.ReadLine());
                        shop.AddProduct(product);
                        Console.WriteLine("---------------------------------------------------------------------------");
                        shop.ShowProducts();
                        Console.WriteLine("---------------------------------------------------------------------------");
                        Console.WriteLine("\nTotal price => " + shop.GetPrice());
                    }
                    break;
                case "2":
                    {
                        Console.Clear();
                        int productId;
                        Console.Write("Id = "); productId = int.Parse(Console.ReadLine());
                        shop.DeleteProduct(productId);
                        Console.WriteLine("---------------------------------------------------------------------------");
                        shop.ShowProducts();
                        Console.WriteLine("---------------------------------------------------------------------------");
                        Console.WriteLine("\nTotal price => " + shop.GetPrice());
                    }
                    break;
                case "3":
                    {
                        Console.Clear();
                        Air air = new Air();
                        Ground ground = new Ground();
                        Sea sea = new Sea();
                        Console.WriteLine("1.Air");
                        Console.WriteLine("2.Ground");
                        Console.WriteLine("3.Sea");
                        string ch = Console.ReadLine();
                        switch (ch)
                        {
                            case "1":
                                {
                                    shop.SetShipping(air);
                                }
                                break;
                            case "2":
                                {
                                    shop.SetShipping(ground);
                                }
                                break;
                            case "3":
                                {
                                    shop.SetShipping(sea);
                                }
                                break;
                        }
                        Console.WriteLine("---------------------------------------------------------------------------");
                        shop.ShowProducts();
                        Console.WriteLine("---------------------------------------------------------------------------");
                        Console.WriteLine("\nTotal price => " + shop.GetPrice());
                    }
                    break;
            }
        } while (choice != "4");
    }
}