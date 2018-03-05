using System.Collections.Generic;

namespace AvansTs.vsts._BackLogItems
{
    public class Item
    {
        List<Tasks> tasks = new List<Tasks>();
        private User itemowner;
        public Item(List<Tasks> tasks,User user)
        {
            this.itemowner = user;
            this.tasks = tasks;
        }
    }
}