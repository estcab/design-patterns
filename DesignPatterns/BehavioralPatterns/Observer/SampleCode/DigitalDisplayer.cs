namespace DesignPatterns.BehavioralPatterns.Observer.SampleCode
{
    public class DigitalDisplayer : ITimeDisplayer 
    {
        public void Display(Time time)
        {
            // Digital display
            string.Format("{0}:{1}:{2}", time.Hour, time.Minute, time.Second);
        }
    }
}