using System;

namespace model
{
    public class User
    {
        private string username;
        private string password;
        private string email;

        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
        public string Email { get => email; set => email = value; }
    }
}