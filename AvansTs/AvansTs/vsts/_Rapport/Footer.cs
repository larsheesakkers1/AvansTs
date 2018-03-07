namespace AvansTs.vsts
{
    public class Footer : RapportDecorator
    {
        private readonly Rapport rapport;

        public Footer(Rapport rap)
        {
            rapport = rap;
        }

        public override string Getlayout()
        {
            return rapport.Getlayout() + " casualFooter";
        }
    }
}