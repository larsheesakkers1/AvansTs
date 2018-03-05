using System;
using System.Collections.Generic;
using System.Linq;
using AvansTs.vsts;
using AvansTs.vsts._BackLogItems;

namespace AvansTs
{
    internal class Project
    {
        public void init(string projectName)
        {
            var Project = new List<Sprint>();
            var userList = new List<User>
            {
                new User("Lars", "developer"),
                new User("Cliff", "Scrum Master"),
                new User("Pascal", "Productowner")
            };
            var items1 = new List<Item>
            {
                new Item(new List<Tasks>
                    {
                        new Tasks("init", "lorem ipsum"),
                        new Tasks("create", "lorem ipsum")
                    },
                    userList[0]
                )
            };

            var ScrumMaster = userList.SingleOrDefault(i => i.role == "Scrum Master");
            Project.Add(new Sprint(ScrumMaster, userList, items1, DateTime.Parse("5/3/2018"),
                DateTime.Parse("9/3/2018")));
        }
    }
}