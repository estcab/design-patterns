namespace DesignPatterns.BehavioralPatterns.ChainOfResponsibility.SampleCode
{
    public class Button : Widget
    {
        public Button(Widget parent, HelpTopic topic = HelpTopic.NoHelp)
            : base(parent, topic)
        {
        }

        public override string HandleHelp()
        {
            if (HasHelp())
            {
                return "Button Help";
            }

            return base.HandleHelp();
        }
    }
}