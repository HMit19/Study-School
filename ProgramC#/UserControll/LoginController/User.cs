using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginController
{
    public class User
    {
        private string username;
        private string password;

        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }

        public User() { }

        public User(User user)
        {
            this.username = user.username;
            this.password = user.password;
        }
        public User(string username, string password)
        {
            this.username = username;
            this.password = password;
        }
    }
}
