using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvansTs.version
{
    abstract class Version
    {
        public Version() {
            Invoker invoker = new Invoker();
            Receiver receiver = new Receiver();
            Concrete concrete = new Concrete(receiver);
            invoker.setCommand(concrete);
        }  
    }
}
