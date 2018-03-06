using Microsoft.VisualStudio.TestTools.UnitTesting;
using AvansTs;
using AvansTs.vsts._BackLogItems;
using System;
using AvansTs.version;
using System.Collections.Generic;
using AvansTs.pipeline;
using AvansTs.vsts;
using AvansTs.vsts._Rapport;

namespace UnitTestAvansTs
{
    [TestClass]
    public class PatternTests
    {
        [TestMethod]
        public void TestMethodObserver()
        {
            var currentConsoleOut = Console.Out;
            Tasks task = new Tasks("","");
            ConcreteTaskObserver conc = new ConcreteTaskObserver(task);
            string text = "Send message\r\n";
            using (var consoleOutput = new ConsoleOutput())
            {
                task.notifyObservers();

                Assert.AreEqual(text, consoleOutput.GetOutput());
            }

            Assert.AreEqual(currentConsoleOut, Console.Out);
        }

        [TestMethod]
        public void TestMethodStates()
        {
            Tasks task = new Tasks("","");
            task.onDoing();
            task.onDone();

            Assert.AreEqual(task.state.ToString(), "AvansTs.vsts._BackLogItems._State.Done");
        }

        [TestMethod]
        public void TestMethodCommand() {
            Invoker invoker = new Invoker();
            Receiver receiver = new Receiver();
            Concrete concrete = new Concrete(receiver);
            invoker.setCommand(concrete);

            var currentConsoleOut = Console.Out;
            string text = "Command executed\r\n";

            using (var consoleOutput = new ConsoleOutput())
            {
                invoker.buttonWasPressed();

                Assert.AreEqual(text, consoleOutput.GetOutput());
            }

            Assert.AreEqual(currentConsoleOut, Console.Out);
        }

        [TestMethod]
        public void TestMethodVisitor() {
            List<DevAction> iterator = new List<DevAction>();

            iterator.Add(new Source());
            iterator.Add(new Utility());
            iterator.Add(new Package());

            DevPipeline pipe = new DevPipeline();

            var currentConsoleOut = Console.Out;
            string text = "AvansTs.pipeline.Source\r\nAvansTs.pipeline.Utility\r\nAvansTs.pipeline.Package\r\n";

            using (var consoleOutput = new ConsoleOutput())
            {
                foreach (var it in iterator)
                {
                    it.accept(pipe);
                }

                Assert.AreEqual(text, consoleOutput.GetOutput());
            }

            Assert.AreEqual(currentConsoleOut, Console.Out);
        }

        [TestMethod]
        public void TestMethodDecorator()
        {
            Rapport rap = new Content();
            rap = new Footer(rap);
            rap = new Header(rap);
            Assert.AreEqual("content casualFooter casualheader", rap.Getlayout());
        }
    }
}
