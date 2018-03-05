using System;

namespace AvansTs.pipeline
{
    public class DevPipeline : IDevPipe
    {
        public void visit(Source source)
        {
            Console.WriteLine(source);
        }

        public void visit(Package package)
        {
            Console.WriteLine(package);
        }

        public void visit(Builds build)
        {
            Console.WriteLine(build);
        }

        public void visit(Tests test)
        {
            Console.WriteLine(test);
        }

        public void visit(Deploys deploy)
        {
            Console.WriteLine(deploy);
        }

        public void visit(Utility utility)
        {
            Console.WriteLine(utility);
        }
    }
}