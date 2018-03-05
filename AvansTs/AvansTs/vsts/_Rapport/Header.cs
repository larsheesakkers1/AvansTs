using System;

namespace AvansTs.vsts
{
    public class Header : RapportDecorator
    {
        Rapport rapport;
        public Header(Rapport rap)
        {
            this.rapport = rap;
        }


        public override string Getlayout()
        {
            return rapport.Getlayout() + " casualheader";
        }
    }
}