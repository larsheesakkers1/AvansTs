using AvansTs.version;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvansTs
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Invoker invoker = new Invoker();
            Receiver receiver = new Receiver();
            Concrete concrete = new Concrete(receiver);
            invoker.setCommand(concrete);
            invoker.buttonWasPressed();
        }
    }
}