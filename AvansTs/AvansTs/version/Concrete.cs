using System;

namespace AvansTs.version
{
    public class Concrete : Command
    {
        private readonly Receiver receiver;

        public Concrete(Receiver receiver)
        {
            this.receiver = receiver;
        }

        public void execute()
        {
            // receiver method
            receiver.run();
        }

        public void undo()
        {
            // receiver method
            throw new NotImplementedException();
        }
    }
}