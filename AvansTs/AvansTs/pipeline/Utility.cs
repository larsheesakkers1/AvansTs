namespace AvansTs.pipeline
{
    public class Utility : DevAction
    {
        public void accept(IDevPipe devPipe)
        {
            devPipe.visit(this);
        }
    }
}