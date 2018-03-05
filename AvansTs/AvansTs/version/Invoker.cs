using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvansTs.version
{
    public class Invoker
    {
        Command command;

        public Invoker() {

        }
        public void setCommand(Command command) {
            this.command = command;
        }

        public void buttonWasPressed() {
            command.execute();
        }
    }
}
