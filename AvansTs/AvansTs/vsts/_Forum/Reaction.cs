namespace AvansTs.vsts._Forum
{
    internal class Reaction
    {
        private string message;
        private User user;

        public Reaction(User user, string message)
        {
            this.message = message;
            this.user = user;
        }
    }
}