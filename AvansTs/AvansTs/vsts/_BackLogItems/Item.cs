using System.Collections.Generic;

namespace AvansTs.vsts._BackLogItems
{
    public class Item
    {
        List<Tasks> tasks = new List<Tasks>();
        private User itemowner;
        private string state;
        public Item(List<Tasks> tasks,User user)
        {
            this.itemowner = user;
            this.tasks = tasks;
        }

        public string getState()
        {
            return state;
        }
    }
}