using System.Collections.Generic;
using AvansTs.vsts._BackLogItems;

namespace AvansTs.vsts._Forum
{
    internal class Subject
    {
        private readonly Item backlogItem;
        private List<Threat> threats;

        public Subject(Item backlogItem, List<Threat> threats)
        {
            this.threats = threats;
            this.backlogItem = backlogItem;
        }

        private bool isAvailable()
        {
            return backlogItem.getState() != "Done";
        }
    }
}