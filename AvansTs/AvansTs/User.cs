using System.Runtime.CompilerServices;
using System.Security.Authentication.ExtendedProtection.Configuration;

namespace AvansTs
{
    public class User
    {
        private string name;
        public string role;

        public User(string name, string role)
        {
            this.name = name;
            this.role = role;
        }
    }
}