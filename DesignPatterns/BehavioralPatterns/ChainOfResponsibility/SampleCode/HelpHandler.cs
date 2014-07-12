using System;

namespace DesignPatterns.BehavioralPatterns.ChainOfResponsibility.SampleCode
{
    public abstract class HelpHandler
    {
        protected HelpHandler Successor;
        protected readonly HelpTopic Topic;

        protected HelpHandler(HelpHandler helpHandler, HelpTopic topic = HelpTopic.NoHelp)
        {
            Successor = helpHandler;
            Topic = topic;
        }

        public virtual string HandleHelp()
        {
            if (Successor != null)
            {
                return Successor.HandleHelp();
            }
            
            return String.Empty;
        }

        public virtual bool HasHelp()
        {
            return Topic != HelpTopic.NoHelp;
        }
    }
}
