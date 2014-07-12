namespace DesignPatterns.BehavioralPatterns.ChainOfResponsibility.SampleCode
{
    public abstract class Widget : HelpHandler
    {
        private readonly Widget _parent;

        protected Widget(Widget parent, HelpTopic topic = HelpTopic.NoHelp) 
            : base(parent, topic)
        {
            _parent = parent;
        }
    }
}