using AvansTs.pipeline;
using AvansTs.version;
using AvansTs.vsts._BackLogItems;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AvansTs.vsts;
using AvansTs.vsts._Forum;
using AvansTs.vsts._Notification;

namespace AvansTs
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //            Project newproject = new Project();
            //            newproject.init("testProject");

            var Project = new List<Sprint>();
            var userList = new List<User>
            {
                new User("Lars", "developer"),
                new User("Cliff", "Scrum Master"),
                new User("Pascal", "Productowner")
            };
            var sprintItems = new List<Item>();
            var items1 =
                new Item(new List<Tasks>
                    {
                        new Tasks("init", "lorem ipsum"),
                        new Tasks("create", "lorem ipsum")
                    },
                    userList[0]
                );
            sprintItems.Add(items1);
            var ScrumMaster = userList.SingleOrDefault(i => i.getRole() == "Scrum Master");
            Project.Add(new Sprint(ScrumMaster, userList, sprintItems, DateTime.Parse("5/3/2018"),
                DateTime.Parse("9/3/2018")));


            var forum = new Forum(new List<Subject>
            {
                new Subject(items1,
                    new List<Threat>
                    {
                        new Threat("discu1",
                            new List<Reaction>
                            {
                                new Reaction(ScrumMaster, "good job"),
                                new Reaction(ScrumMaster, "next time do this")
                            }),
                        new Threat("discu2",
                            new List<Reaction>
                            {
                                new Reaction(ScrumMaster, "do this"),
                                new Reaction(ScrumMaster, "look at this link......")
                            })
                    })
            });
        
            Project[0].onFinished();
            //Invoker invoker = new Invoker();
            //Receiver receiver = new Receiver();
            //Concrete concrete = new Concrete(receiver);
            //invoker.setCommand(concrete);
            //invoker.buttonWasPressed();

            //            List<DevAction> iterator = new List<DevAction>();
            //
            //            iterator.Add(new Source());
            //            iterator.Add(new Utility());
            //            iterator.Add(new Package());
            //
            //            DevPipeline pipe = new DevPipeline();
            //
            //            foreach (var it in iterator)
            //            {
            //                it.accept(pipe);
            //            }

            //Tasks task = new Tasks();
            //Console.WriteLine(task.state);
            //task.onDoing();
            //task.onToDo();
            //Console.WriteLine(task.state);
            //task.onDone();
            //Console.WriteLine(task.state);

            //Console.WriteLine(task.state);

            //            Tasks task = new Tasks("","");
            //            ConcreteTaskObserver conc = new ConcreteTaskObserver(task);
            //            task.onDoing();
            //            task.onDone();
            //            task.notifyObservers();

            //Rapport rap = new SaveDocx();
            //rap = new Footer(rap);
            //rap = new Header(rap);
            //Console.WriteLine(rap.Getlayout());
        }
    }
}