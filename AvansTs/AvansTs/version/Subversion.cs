using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace AvansTs.version
{
    public class Subversion : Version
    {
        public bool Command(string comm)
        {
            Console.WriteLine("run commmand in subversion -> " + comm);
            return true;
        }
    }
}
