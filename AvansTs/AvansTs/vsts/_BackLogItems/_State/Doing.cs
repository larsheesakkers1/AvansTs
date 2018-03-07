using System;

namespace AvansTs.vsts._BackLogItems._State
{
    public class Doing : IState
    {
        public IState doing()
        {
            throw new NotImplementedException();
        }

        public IState done()
        {
            return new Done();
        }

        public IState todo()
        {
            throw new NotImplementedException();
        }
    }
}