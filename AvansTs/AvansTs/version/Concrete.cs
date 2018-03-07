using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvansTs.version
{
    public class Concrete : Command
    {
        Receiver receiver;

        public Concrete(Receiver receiver) {
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
