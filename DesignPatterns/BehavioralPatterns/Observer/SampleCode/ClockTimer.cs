using System.Threading;

namespace DesignPatterns.BehavioralPatterns.Observer.SampleCode
{
    public class ClockTimer : Subject
    {
        private readonly Time _time;

        public ClockTimer(Time time)
        {
            _time = time;
        }

        public Time GetTime()
        {
            return _time;
        }

        public void Tick()
        {
            // update internal state
            for (int i = 0; i < 5; i++)
            {
                Thread.Sleep(950);
                _time.Update(0, 0, 1);
            }
            

            Notify();
        }
    }
}