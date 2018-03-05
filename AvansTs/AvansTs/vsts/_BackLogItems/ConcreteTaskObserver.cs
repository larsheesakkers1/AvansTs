using AvansTs.vsts._Notification;
using System;

namespace AvansTs.vsts._BackLogItems
{
    public class ConcreteTaskObserver : ITaskObserver
    {
        private ITaskSubject task;
        public ConcreteTaskObserver(ITaskSubject task) {
            this.task = task;
            task.registerObserver(this);
        }
        public void update()
        {
            NotificationService NS = NotificationService.getInstance();
            NS.notify(new Mail(), "Task state is - >" + this.task.getState());
        }
    }
}