namespace DesignPatterns.BehavioralPatterns.ChainOfResponsibility.SampleCode
{
    public class Application : HelpHandler
    {
        public Application(HelpTopic topic) 
            : base(null, topic)
        {
        }

        public override string HandleHelp()
        {
            if (HasHelp())
            {
                return "Application Help";
            }
            
            return base.HandleHelp();
        }
    }
}