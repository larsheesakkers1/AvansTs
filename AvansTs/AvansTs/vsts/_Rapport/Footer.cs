using AvansTs.vsts;

namespace AvansTs.vsts
{
    public class Footer : RapportDecorator
    {
        Rapport rap;
        public Footer(Rapport rap)
        {
            this.rap = rap;
        }

        public override string Getlayout()
        {
            return rap.Getlayout() + " casualFooter";
        }
    }
}