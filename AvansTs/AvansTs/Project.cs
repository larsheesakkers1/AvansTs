using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using AvansTs.vsts;

namespace AvansTs
{
    internal class Project
    {
        public void init(string projectName)
        {
            List<User> userList = new List<User>();
            List<Sprint> Project = new List<Sprint>();
            userList.Add(new User("Lars","developer"));
            userList.Add(new User("Cliff","Scrum Master"));
            userList.Add(new User("Pascal","Productowner"));

            var ScrumMaster = userList.Where(i => i.role == "Scrum Master").SingleOrDefault();
            Project.Add(new Sprint(ScrumMaster, userList,DateTime.Parse("5/3/2018"), DateTime.Parse("9/3/2018")));
            
        }
    }
}