namespace AvansTs.version
{
    public interface Command
    {
        void execute();
        void undo();
    }
}