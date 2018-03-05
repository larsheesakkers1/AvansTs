using System.Collections.Generic;

namespace AvansTs.vsts._Forum
{
    internal class Threat
    {
        private List<Reaction> reactions;
        private string name;
        public Threat(string name,List<Reaction> reactions)
        {
            this.name = name;
            this.reactions = reactions;
        }
    }
}