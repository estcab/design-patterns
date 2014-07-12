using DesignPatterns.BehavioralPatterns.ChainOfResponsibility.SampleCode;
using DesignPatterns.BehavioralPatterns.ChainOfResponsibility.Structure;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DesignPatterns.Tests
{
    [TestClass]
    public class ChainOfResponsibilityTests
    {
        [TestMethod]
        public void ConcreteHandler2_HandlesRequest()
        {
            var handler1 = new ConcreteHandler1();
            var handler2 = new ConcreteHandler2();

            handler1.Successor = handler2;

            var client = new Client(handler1);

            var result = client.DoWork();

            Assert.AreEqual("ConcreteHandler2", result);
        }

        [TestMethod]
        public void ButtonDialog_NotHandlingRequests_Application()
        {
            var app = new Application(HelpTopic.Application);
            var dialog = new Dialog(app, HelpTopic.NoHelp);
            var button = new Button(dialog, HelpTopic.NoHelp);

            var result = button.HandleHelp();

            Assert.AreEqual(result, "Application Help");

        }

        [TestMethod]
        public void Button_NotHandlingRequests_Dialog()
        {
            var app = new Application(HelpTopic.Application);
            var dialog = new Dialog(app, HelpTopic.PaperOrientation);
            var button = new Button(dialog, HelpTopic.NoHelp);

            var result = button.HandleHelp();

            Assert.AreEqual(result, "Dialog Help");

        }
    }
}
