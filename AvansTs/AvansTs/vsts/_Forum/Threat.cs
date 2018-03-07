using System.Collections.Generic;

namespace AvansTs.vsts._Forum
{
    internal class Threat
    {
        private string name;
        private List<Reaction> reactions;

        public Threat(string name, List<Reaction> reactions)
        {
            this.name = name;
            this.reactions = reactions;
        }
    }
}