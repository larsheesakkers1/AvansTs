namespace AvansTs.vsts._BackLogItems._State
{
    public class Doing : IState
    {
        public IState doing()
        {
            throw new System.NotImplementedException();
        }

        public IState done()
        {
            return new Done();
        }

        public IState todo()
        {
            throw new System.NotImplementedException();
        }
    }
}