using System;
using System.Collections.Generic;
using AvansTs.pipeline;
using AvansTs.vsts._BackLogItems;
using AvansTs.vsts._Notification;

namespace AvansTs.vsts
{
    internal class Sprint
    {
        private User scrummaster;
        private List<Item> items;
        private DateTime startDate;
        private DateTime endDate;
        private string state;

        public Sprint(User scrummaster, List<User> restOfTeam, List<Item> items, DateTime startDate, DateTime endDate)
        {
            this.endDate = endDate;
            this.startDate = startDate;
            this.items = items;
            this.scrummaster = scrummaster;
        }

        private bool isEditAble()
        {
            var today = DateTime.Today;
            return today < startDate;
        }

        public void onFinished()
        {
            var today = DateTime.Today;
            if (today > endDate)
            {
                this.state = "Finished";
                this.sprintRelease();
            }
        }

        public void onComplete()
        {
            Upload up = new Upload("Release", "/releases");
            this.state = "Complete";
        }

        public void sprintRelease()
        {
            List<DevAction> iterator = new List<DevAction>();
            
            iterator.Add(new Source());
            iterator.Add(new Utility());
            iterator.Add(new Package());
            
            DevPipeline pipe = new DevPipeline();
            
            foreach (var it in iterator)
            {
                it.accept(pipe);
            }

            
            NotificationService NS = NotificationService.getInstance();
            NS.notify(new Slack(), "The release has been succesfull");
            onComplete();
        }

    }
}