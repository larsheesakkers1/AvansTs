namespace AvansTs.vsts
{
    public class Header : RapportDecorator
    {
        private readonly Rapport rapport;

        public Header(Rapport rap)
        {
            rapport = rap;
        }


        public override string Getlayout()
        {
            return rapport.Getlayout() + " casualheader";
        }
    }
}