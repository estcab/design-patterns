namespace DesignPatterns.BehavioralPatterns.Observer.SampleCode
{
    public class DigitalClock : ClockBase
    {
        public DigitalClock(ClockTimer clockTimer)
            : base(clockTimer, new DigitalDisplayer())
        {
        }
    }
}