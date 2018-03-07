namespace AvansTs.pipeline
{
    public interface IDevPipe
    {
        void visit(Source source);
        void visit(Package package);
        void visit(Builds build);
        void visit(Tests test);
        void visit(Deploys deploy);
        void visit(Utility utility);
    }
}