using AvansTs.vsts._BackLogItems._State;
using System;
using System.Collections.Generic;

namespace AvansTs.vsts._BackLogItems
{
    public class Tasks : ITaskSubject
    {
        private List<ITaskObserver> obs;
        public IState state;

        public Tasks(string name,string description) {
            this.state = new ToDo();
            obs = new List<ITaskObserver>();
        }

        public void registerObserver(ITaskObserver o)
        {
            obs.Add(o);
        }

        public void removeObserver(ITaskObserver o)
        {
            obs.Remove(o);
        }

        public void notifyObservers()
        {
            for (int i = 0; i < obs.Count; i++)
            {
                ITaskObserver observer = obs[i];
                observer.update();
            }
        }
        private void setState(IState state) {
            this.state = state;
        }

        public void onDoing() {
            Console.WriteLine("Doing");
            setState(this.state.doing());
        }
        public void onToDo()
        {
            Console.WriteLine("ToDo");
            setState(this.state.todo());
        }
        public void onDone()
        {
            Console.WriteLine("Done");
            setState(this.state.done());
        }

    }
}