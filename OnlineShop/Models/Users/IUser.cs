//----------------------------------------
// Tarteeb School (c) All rights reserved
//----------------------------------------

namespace OnlineShop.Models.Users
{
    internal interface IUser
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
    }
}
