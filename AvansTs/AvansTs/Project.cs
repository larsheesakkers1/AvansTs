using System;
using System.Collections.Generic;
using System.Linq;
using AvansTs.vsts;
using AvansTs.vsts._BackLogItems;
using AvansTs.vsts._Forum;

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
            var sprintItems = new List<Item>();
            var items1 =
                new Item(new List<Tasks>
                    {
                        new Tasks("init", "lorem ipsum"),
                        new Tasks("create", "lorem ipsum")
                    },
                    userList[0]
                );
            sprintItems.Add(items1);
            var ScrumMaster = userList.SingleOrDefault(i => i.getRole() == "Scrum Master");
            Project.Add(new Sprint(ScrumMaster, userList, sprintItems, DateTime.Parse("5/3/2018"),
                DateTime.Parse("9/3/2018")));


            var forum = new Forum(new List<Subject>
            {
                new Subject(items1,
                    new List<Threat>
                    {
                        new Threat("discu1",
                            new List<Reaction>
                            {
                                new Reaction(ScrumMaster, "good job"),
                                new Reaction(ScrumMaster, "next time do this")
                            }),
                        new Threat("discu2",
                            new List<Reaction>
                            {
                                new Reaction(ScrumMaster, "do this"),
                                new Reaction(ScrumMaster, "look at this link......")
                            })
                    })
            });
        }
    }
}