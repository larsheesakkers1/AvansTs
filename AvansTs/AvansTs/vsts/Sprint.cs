using System;
using System.Collections.Generic;
using AvansTs.pipeline;
using AvansTs.vsts._BackLogItems;
using AvansTs.vsts._Notification;

namespace AvansTs.vsts
{
    internal class Sprint
    {
        private readonly DateTime endDate;
        private List<Item> items;
        private User scrummaster;
        private readonly DateTime startDate;
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
                state = "Finished";
                sprintRelease();
            }
        }

        public void onComplete()
        {
            var up = new Upload("Release", "/releases");
            state = "Complete";
        }

        public void sprintRelease()
        {
            var iterator = new List<DevAction>();

            iterator.Add(new Source());
            iterator.Add(new Utility());
            iterator.Add(new Package());

            var pipe = new DevPipeline();

            foreach (var it in iterator) it.accept(pipe);


            var NS = NotificationService.getInstance();
            NS.notify(new Slack(), "The release has been succesfull");
            onComplete();
        }
    }
}