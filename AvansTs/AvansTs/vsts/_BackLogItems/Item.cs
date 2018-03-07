using System.Collections.Generic;
using AvansTs.vsts._BackLogItems._State;

namespace AvansTs.vsts._BackLogItems
{
    public class Item
    {
        private User itemowner;
        private string state;
        public List<Tasks> tasks = new List<Tasks>();

        public Item(List<Tasks> tasks, User user)
        {
            itemowner = user;
            this.tasks = tasks;
        }

        public string getState()
        {
            var check = true;
            foreach (var task in tasks)
                if (!task.getState().GetType().Equals(new Done().GetType()))
                    check = false;

            if (check) state = "Done";
            return state;
        }
    }
}