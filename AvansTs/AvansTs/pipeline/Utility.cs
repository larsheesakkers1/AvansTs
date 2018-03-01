namespace AvansTs.pipeline
{
    internal class Utility : DevAction
    {
        public void accept(IDevPipe devPipe)
        {
            devPipe.visit(this);
        }
    }
}