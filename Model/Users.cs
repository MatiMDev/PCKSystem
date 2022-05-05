using System;
using System.Collections.Generic;
using System.Text;

namespace PCKSystem.Model
{
    internal class Users
    {
        List<User> usersList = new List<User>
        {
            new User("username", "password"),
            new User("admin", "test")
        };

        public List<User> UsersList { get { return usersList; } }
    }
}
