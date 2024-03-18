//----------------------------------------
// Tarteeb School (c) All rights reserved
//----------------------------------------

using OnlineShop.Brokers.Storages;
using OnlineShop.Models.Users;
using System;
using System.Collections.Generic;

namespace OnlineShop.Services.Auth
{
    internal class Auth : IAuth
    {
        private IStorage fileStorage;
        public Auth()
        {
            fileStorage = new FileStorage();
        }
        public bool LogIn(User user)
        {
            List<User> users = fileStorage.GetUsers();
            foreach(var u in  users)
            {
                if (u.Id == user.Id && u.Username == user.Username && u.Password == user.Password)
                {
                    return true;
                }
            }

            return false;
        }

        public User SignUp(User user)
        {
            if(this.LogIn(user))
            {
                user.Id = -1;
            }
            else
            {
                fileStorage.AddUser(user);
            }
            return user;
        }
    }
}
