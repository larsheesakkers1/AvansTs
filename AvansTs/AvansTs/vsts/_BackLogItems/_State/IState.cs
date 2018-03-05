namespace AvansTs.vsts._BackLogItems._State
{
    public interface IState
    {
        IState doing();
        IState done();
        IState todo();
    }
}