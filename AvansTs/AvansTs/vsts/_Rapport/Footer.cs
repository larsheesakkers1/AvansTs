using AvansTs.vsts;

namespace AvansTs.vsts
{
    public class Footer : RapportDecorator
    {
        Rapport rapport;
        public Footer(Rapport rap)
        {
            this.rapport = rap;
        }

        public override string Getlayout()
        {
            return rapport.Getlayout() + " casualFooter";
        }
    }
}