using AvansTs.pipeline;
using AvansTs.version;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AvansTs.vsts;

namespace AvansTs
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //Invoker invoker = new Invoker();
            //Receiver receiver = new Receiver();
            //Concrete concrete = new Concrete(receiver);
            //invoker.setCommand(concrete);
            //invoker.buttonWasPressed();
            List<DevAction> iterator = new List<DevAction>();

            iterator.Add(new Source());
            iterator.Add(new Utility());
            iterator.Add(new Package());

            DevPipeline pipe = new DevPipeline();

            foreach (var it in iterator)
            {
                it.accept(pipe);
            }
            Rapport rap = new SaveDocx();
            rap = new Footer(rap);
            rap = new Header(rap);
            Console.WriteLine(rap.Getlayout());
            Console.WriteLine("s");
        }
    }
}