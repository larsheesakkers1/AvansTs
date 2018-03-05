namespace AvansTs.pipeline
{
    public abstract class Deploys : DevAction
    {
        public void accept(IDevPipe devPipe)
        {
            devPipe.visit(this);
        }
    }
}