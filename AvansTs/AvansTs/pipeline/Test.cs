namespace AvansTs.pipeline
{
    public abstract class Tests : DevAction
    {
        public void accept(IDevPipe devPipe)
        {
            devPipe.visit(this);
        }
    }
}