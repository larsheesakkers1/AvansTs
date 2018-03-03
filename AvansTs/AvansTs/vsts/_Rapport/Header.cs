using System;

namespace AvansTs.vsts
{
    public class Header : RapportDecorator
    {
        Rapport rap;
        public Header(Rapport rap)
        {
            this.rap = rap;
        }


        public override string Getlayout()
        {
            return rap.Getlayout() + " casualheader";
        }
    }
}