namespace AvansTs.pipeline
{
    public class Source : DevAction
    {
        public void accept(IDevPipe devPipe)
        {
            devPipe.visit(this);
        }
    }
}