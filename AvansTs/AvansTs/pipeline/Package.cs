namespace AvansTs.pipeline
{
    public class Package : DevAction
    {
        public void accept(IDevPipe devPipe)
        {
            devPipe.visit(this);
        }
    }
}