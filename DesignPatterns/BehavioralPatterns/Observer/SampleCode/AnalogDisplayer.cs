namespace DesignPatterns.BehavioralPatterns.Observer.SampleCode
{
    public class AnalogDisplayer : ITimeDisplayer
    {
        public void Display(Time time)
        {
            // Analog display
            string.Format("{0} - {1} - {2}", time.Hour, time.Minute, time.Second);
        }
    }
}