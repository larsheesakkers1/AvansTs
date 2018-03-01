namespace AvansTs.pipeline
{
    internal class Package : DevAction
    {
        public void accept(IDevPipe devPipe)
        {
            devPipe.visit(this);
        }
    }
}