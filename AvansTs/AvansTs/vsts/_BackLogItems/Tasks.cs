using AvansTs.vsts._BackLogItems._State;
using System;

namespace AvansTs.vsts._BackLogItems
{
    class Tasks : ITaskSubject
    {
        public IState state;

        public Tasks() {
            this.state = new ToDo();
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