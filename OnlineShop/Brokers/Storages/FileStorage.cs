//----------------------------------------
// Tarteeb School (c) All rights reserved
//----------------------------------------

using OnlineShop.Models.Users;
using System.Collections.Generic;
using System.IO;

namespace OnlineShop.Brokers.Storages
{
    internal class FileStorage : IStorage
    {
        private readonly string path = "../../../Assets/users.txt";
        public FileStorage()
        {
            this.CheckFileExsist();  
        }
        public void AddUser(IUser user)
        {
            File.AppendAllText(path, user.ToString() + "\n");
        }

        public List<IUser> GetUsers()
        {
            List<IUser> oldUsers = new List<IUser>();
            string[] allLines = File.ReadAllLines(path);
            foreach (string line in allLines)
            {
                IUser user = new User();
                string[] data = line.Split('*');
                user.Id = int.Parse(data[0]);
                user.Username = data[1];
                user.Password = data[2];
                oldUsers.Add(user);
            }

            return oldUsers;
        }

        void CheckFileExsist()
        {
            if(!File.Exists(path))
            {
                File.Create(path).Close();
            }
        }
    }
}
