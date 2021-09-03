using System;
using System.Collections.Generic;
using System.Text;

namespace BancoJavi.Classes
{
    class User
    {
        public string UserId;
        public string UserPass;

        public User(string userId, string userPass)
        {
            this.UserId = userId;
            this.UserPass = userPass;
        }
    }
}
