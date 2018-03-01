using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvansTs.version
{
    class Concrete : Command
    {
        Receiver receiver;

        public Concrete(Receiver receiver) {
            this.receiver = receiver;
        }
        public void execute()
        {
            // receiver method
            receiver.test();
        }

        public void undo()
        {
            // receiver method
            throw new NotImplementedException();
        }
    }
}
