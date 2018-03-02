using System;

namespace AvansTs.vsts
{
    public abstract class Rapport
    {
        public string rap = "Rapport content";

        public virtual string Getlayout()
        {
            return rap;
        }
    }
}