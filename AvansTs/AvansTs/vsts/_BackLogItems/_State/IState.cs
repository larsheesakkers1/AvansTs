namespace AvansTs.vsts._BackLogItems._State
{
    internal interface IState
    {
        IState doing();
        IState done();
        IState todo();
    }
}