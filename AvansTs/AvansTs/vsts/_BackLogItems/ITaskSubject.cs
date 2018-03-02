namespace AvansTs.vsts._BackLogItems
{
    interface ITaskSubject
    {
        void registerObserver(ITaskObserver o);
        void removeObserver(ITaskObserver o);
        void notifyObservers();
    }
}