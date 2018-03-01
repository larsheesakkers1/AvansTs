namespace AvansTs.version
{
    internal abstract class Version
    {
        public Version() {
            Invoker invoker = new Invoker();
            Receiver receiver = new Receiver();
            Concrete concrete = new Concrete(receiver);
            invoker.setCommand(concrete);
        }  
    }
}