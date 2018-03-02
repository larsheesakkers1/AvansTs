using AvansTs.pipeline;
using AvansTs.version;
using AvansTs.vsts._BackLogItems;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            //List<DevAction> iterator = new List<DevAction>();

            //iterator.Add(new Source());
            //iterator.Add(new Utility());
            //iterator.Add(new Package());

            //DevPipeline pipe = new DevPipeline();

            //foreach (var it in iterator)
            //{
            //    it.accept(pipe);
            //}

            Tasks task = new Tasks();
            Console.WriteLine(task.state);
            task.onDoing();
            task.onToDo();
            Console.WriteLine(task.state);
            task.onDone();
            Console.WriteLine(task.state);

            Console.WriteLine(task.state);
        }
    }
}