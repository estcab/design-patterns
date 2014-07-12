namespace DesignPatterns.BehavioralPatterns.ChainOfResponsibility.SampleCode
{
    public class Dialog : Widget
    {
        public Dialog(HelpHandler helpHandler, HelpTopic topic = HelpTopic.NoHelp)
            : base(null, topic)
        {
            Successor = helpHandler;
        }

        public override string HandleHelp()
        {
            if (HasHelp())
            {
                return "Dialog Help";
            }
            else
            {
                return base.HandleHelp();
            }
        }
    }
}