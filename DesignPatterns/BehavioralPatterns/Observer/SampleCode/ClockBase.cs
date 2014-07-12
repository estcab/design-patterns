using System;

namespace DesignPatterns.BehavioralPatterns.Observer.SampleCode
{
    public abstract class ClockBase : IObserver, IDisposable
    {
        private readonly ClockTimer _clockTimer;
        private readonly ITimeDisplayer _timeDisplayer;

        private Time _time;

        protected ClockBase(ClockTimer clockTimer, ITimeDisplayer timeDisplayer)
        {
            _clockTimer = clockTimer;
            _timeDisplayer = timeDisplayer;
            _clockTimer.Attach(this);
        }

        public Time Time { get; set; }

        public void Update(Subject subject)
        {
            if (subject == _clockTimer)
            {
                _time = _clockTimer.GetTime();
                _timeDisplayer.Display(Time);
            }
        }

        public void Dispose()
        {
            _clockTimer.Detach(this);
        }
    }
}