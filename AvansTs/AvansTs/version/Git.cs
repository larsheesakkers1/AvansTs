using System;

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