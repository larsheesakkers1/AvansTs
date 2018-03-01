using System;

namespace AvansTs.pipeline
{
    abstract class Builds : DevAction
    {
        public void accept(IDevPipe devPipe)
        {
            devPipe.visit(this);
        }
    }
}