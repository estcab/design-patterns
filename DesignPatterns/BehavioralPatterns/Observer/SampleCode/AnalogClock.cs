namespace DesignPatterns.BehavioralPatterns.Observer.SampleCode
{
    public class AnalogClock  : ClockBase
    {
        public AnalogClock(ClockTimer clockTimer) 
            : base(clockTimer, new AnalogDisplayer())
        {
        }
    }
    
}