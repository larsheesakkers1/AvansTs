using System;
using System.Collections.Generic;
using System.Linq;
using AvansTs.vsts._BackLogItems._State;

namespace AvansTs.vsts._BackLogItems
{
    public class Item
    {
        public List<Tasks> tasks = new List<Tasks>();
        private User itemowner;
        private string state;

        public Item(List<Tasks> tasks,User user)
        {
            this.itemowner = user;
            this.tasks = tasks;
        }

        public string getState()
        {
            bool check = true;
            foreach (var task in tasks)
            {
                if (!task.getState().GetType().Equals(new Done().GetType()))
                {
                    check = false;
                }
            }

            if (check)
            {
                state = "Done";
            }
            return state;
        }
    }
}