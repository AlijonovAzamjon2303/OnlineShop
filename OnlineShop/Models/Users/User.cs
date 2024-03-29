﻿//----------------------------------------
// Tarteeb School (c) All rights reserved
//----------------------------------------

namespace OnlineShop.Models.Users
{
    internal class User
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        public override string ToString()
        {
            return $"{this.Id}*{this.Username}*{this.Password}";
        }
    }
}
