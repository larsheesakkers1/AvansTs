namespace AvansTs.version
{
    public abstract class Version
    {
        public Version()
        {
            var invoker = new Invoker();
            var receiver = new Receiver();
            var concrete = new Concrete(receiver);
            invoker.setCommand(concrete);
        }
    }
}