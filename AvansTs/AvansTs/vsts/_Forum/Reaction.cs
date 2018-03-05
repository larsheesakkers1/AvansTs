using System.Runtime.CompilerServices;

namespace AvansTs.vsts._Forum
{
    internal class Reaction
    {
        private User user;
        private string message;
        public Reaction(User user,string message)
        {
            this.message = message;
            this.user = user;
        }
    }
}