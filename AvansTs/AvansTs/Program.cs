using AvansTs.pipeline;
using AvansTs.version;
using AvansTs.vsts._BackLogItems;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AvansTs.vsts;
using AvansTs.vsts._Notification;

namespace AvansTs
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Project newproject = new Project();
            newproject.init("testProject");
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

            //Tasks task = new Tasks();
            //Console.WriteLine(task.state);
            //task.onDoing();
            //task.onToDo();
            //Console.WriteLine(task.state);
            //task.onDone();
            //Console.WriteLine(task.state);

            //Console.WriteLine(task.state);

            Tasks task = new Tasks();
            ConcreteTaskObserver conc = new ConcreteTaskObserver(task);
            ConcreteTaskObserver conc1 = new ConcreteTaskObserver(task);
            ConcreteTaskObserver conc2 = new ConcreteTaskObserver(task);
            ConcreteTaskObserver conc3 = new ConcreteTaskObserver(task);
            task.notifyObservers();

            NotificationService NS = NotificationService.getInstance();
            NS.notify(new Mail(),"Task state is - >" + task.state);


            Rapport rap = new SaveDocx();
            rap = new Footer(rap);
            rap = new Header(rap);
            Console.WriteLine(rap.Getlayout());
        }
    }
}