﻿using System;

namespace AvansTs.vsts._BackLogItems._State
{
    public class ToDo : IState
    {
        public IState doing()
        {
            return new Doing();
        }

        public IState done()
        {
            throw new NotImplementedException();
        }

        public IState todo()
        {
            throw new NotImplementedException();
        }
    }
}