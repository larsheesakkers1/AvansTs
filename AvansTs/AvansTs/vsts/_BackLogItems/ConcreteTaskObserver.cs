using System;

namespace AvansTs.vsts._BackLogItems
{
    internal class ConcreteTaskObserver : ITaskObserver
    {
        private ITaskSubject task;
        public ConcreteTaskObserver(ITaskSubject task) {
            this.task = task;
            task.registerObserver(this);
        }
        public void update()
        {
            Console.WriteLine("Update task");
        }
    }
}