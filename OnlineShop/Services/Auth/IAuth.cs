//----------------------------------------
// Tarteeb School (c) All rights reserved
//----------------------------------------

using OnlineShop.Models.Users;
using System.Collections.Generic;

namespace OnlineShop.Services.Auth
{
    internal interface IAuth
    {
        bool LogIn(User user);
        User SignUp(User user);
    }
}
