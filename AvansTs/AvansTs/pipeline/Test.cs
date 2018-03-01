namespace AvansTs.pipeline
{
    abstract class Tests : DevAction
    {
        public void accept(IDevPipe devPipe)
        {
            devPipe.visit(this);
        }
    }
}