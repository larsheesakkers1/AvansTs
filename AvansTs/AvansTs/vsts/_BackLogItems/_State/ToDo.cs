namespace AvansTs.vsts._BackLogItems._State
{
    internal class ToDo : IState
    {
        public IState doing()
        {
            return new Doing();
        }

        public IState done()
        {
            throw new System.NotImplementedException();
        }

        public IState todo()
        {
            throw new System.NotImplementedException();
        }
    }
}