using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvansTs.version
{
    public class Git : Version
    {
        public bool Command(string comm)
        {
            Console.WriteLine("run commmand in git-> " + comm);
            return true;
        }
    }

}
    