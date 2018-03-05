using System;
using System.Collections.Generic;
using AvansTs.vsts._BackLogItems;

namespace AvansTs.vsts
{
    internal class Sprint : IBackLog
    {
        private User scrummaster;
        private List<Item> items;
        private DateTime startDate;
        private DateTime endDate;

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

    }
}