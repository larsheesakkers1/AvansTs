namespace AvansTs.pipeline
{
    public abstract class Builds : DevAction
    {
        public void accept(IDevPipe devPipe)
        {
            devPipe.visit(this);
        }
    }
}