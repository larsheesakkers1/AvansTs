namespace AvansTs
{
    public class User
    {
        private string name;
        private readonly string role;

        public User(string name, string role)
        {
            this.name = name;
            this.role = role;
        }

        public string getRole()
        {
            return role;
        }
    }
}