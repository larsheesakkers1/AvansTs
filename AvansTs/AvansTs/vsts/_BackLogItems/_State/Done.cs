using System;

namespace AvansTs.vsts._BackLogItems._State
{
    public class Done : IState
    {
        public IState doing()
        {
            throw new NotImplementedException();
        }

        public IState done()
        {
            throw new NotImplementedException();
        }

        public IState todo()
        {
            return new ToDo();
        }
    }
}