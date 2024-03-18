//----------------------------------------
// Tarteeb School (c) All rights reserved
//----------------------------------------

using OnlineShop.Models.Users;
using System.Collections.Generic;

namespace OnlineShop.Brokers.Storages
{
    internal interface IStorage
    {
        List<User> GetUsers();
        void AddUser(User user);
    }
}
