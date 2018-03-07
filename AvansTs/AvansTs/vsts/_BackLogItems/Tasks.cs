using System;
using System.Collections.Generic;
using AvansTs.vsts._BackLogItems._State;

namespace AvansTs.vsts._BackLogItems
{
    public class Tasks : ITaskSubject
    {
        private readonly List<ITaskObserver> obs;
        public IState state;

        public Tasks(string name, string description)
        {
            state = new ToDo();
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
            for (var i = 0; i < obs.Count; i++)
            {
                var observer = obs[i];
                observer.update();
            }
        }

        public IState getState()
        {
            return state;
        }

        private void setState(IState state)
        {
            this.state = state;
        }

        public void onDoing()
        {
            Console.WriteLine("Doing");
            setState(state.doing());
        }

        public void onToDo()
        {
            Console.WriteLine("ToDo");
            setState(state.todo());
        }

        public void onDone()
        {
            Console.WriteLine("Done");
            setState(state.done());
        }
    }
}