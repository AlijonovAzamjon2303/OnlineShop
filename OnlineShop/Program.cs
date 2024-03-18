//----------------------------------------
// Tarteeb School (c) All rights reserved
//----------------------------------------

using OnlineShop.Brokers.Loggings;
using OnlineShop.Models.Products;
using OnlineShop.Models.Users;
using OnlineShop.Services.Auth;
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
        Console.WriteLine("Savdoni boshlashingiz mumkin");
    }
}