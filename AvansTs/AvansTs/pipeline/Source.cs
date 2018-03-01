namespace AvansTs.pipeline
{
    internal class Source : DevAction
    {
        public void accept(IDevPipe devPipe)
        {
            devPipe.visit(this);
        }
    }
}