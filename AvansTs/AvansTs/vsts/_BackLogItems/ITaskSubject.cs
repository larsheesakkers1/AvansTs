using AvansTs.vsts._BackLogItems._State;

namespace AvansTs.vsts._BackLogItems
{
    public interface ITaskSubject
    {
        void registerObserver(ITaskObserver o);
        void removeObserver(ITaskObserver o);
        void notifyObservers();

        IState getState();
    }
}