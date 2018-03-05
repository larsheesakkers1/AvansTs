namespace AvansTs.vsts._BackLogItems._State
{
    public class Done : IState
    {
        public IState doing()
        {
            throw new System.NotImplementedException();
        }

        public IState done()
        {
            throw new System.NotImplementedException();
        }

        public IState todo()
        {
            return new ToDo();
        }
    }
}