using System;

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